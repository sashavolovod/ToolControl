using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ToolControl
{
    public partial class ToolView : UserControl
    {
        public ToolEntity toolEntity { get; set; }
        public ToolView(ToolEntity toolEntity)
        {
            this.toolEntity = toolEntity;

            InitializeComponent();
            cbStatus.MouseWheel += CbStatus_MouseWheel;
            lbOrderNumber.Text = toolEntity.orderNumber.ToString();
            lbToolTitle.Text = toolEntity.toolTitle;
            lbEmploeeName.Text = toolEntity.employeeName;
            lbWorkerName.Text = toolEntity.workerName;
            lbWeight.Text = toolEntity.weight.ToString();
            lbDetailNumber.Text = toolEntity.detailNumber;
            cbStatus.SelectedIndex = toolEntity.status;
            if (toolEntity.date == DateTime.MinValue)
            {
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = " ";
            }
            else
            {
                dtp.Value = toolEntity.date;
                dtp.Format = DateTimePickerFormat.Short;
            }

            if (toolEntity.status == 0)
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                dtp.Visible = true;
            }
            else
            {
                BackColor = System.Drawing.SystemColors.Control;
                dtp.Visible = false;
            }
            cbStatus.SelectedIndexChanged += CbStatus_SelectedIndexChanged;
            dtp.ValueChanged += Dtp_ValueChanged;
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            if(toolEntity.status == 0)
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
            CbStatus_SelectedIndexChanged(null, null);
        }

        private void CbStatus_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryString = "UPDATE tblToolControl SET status = ?, [date] = ? WHERE orderNumber=?";
            Cursor = Cursors.WaitCursor;

            toolEntity.status = cbStatus.SelectedIndex;

            using (OleDbConnection connection = new OleDbConnection(ToolControl.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                command.Parameters.AddWithValue("@status", toolEntity.status);

                if (toolEntity.status == 0)
                    command.Parameters.AddWithValue("@date", dtp.Value.Date);
                else
                    command.Parameters.AddWithValue("@date", DBNull.Value);

                command.Parameters.AddWithValue("@orderNumber", toolEntity.orderNumber);

                connection.Open();
                if(command.ExecuteNonQuery()==1)
                {
                    if (toolEntity.status == 0)
                    {
                        BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                        dtp.Visible = true;
                    }
                    else
                    {
                        BackColor = System.Drawing.SystemColors.Control;
                        dtp.Visible = false;
                    }
                }
            }
            Cursor = Cursors.Default;
        }
        public ToolView()
        {
            InitializeComponent();
        }
    }
}
