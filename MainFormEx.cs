using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolControl
{
    public partial class MainFormEx : Form
    {
        Dictionary<int, Point> coords = new Dictionary<int, Point>();
        protected void createCoords()
        {
            coords.Clear();

            // row 1
            coords.Add(86314, new Point(232,  69));
            coords.Add(88190, new Point(453,  69));
            coords.Add(91997, new Point(674,  69));
            coords.Add(87881, new Point(917,  69));
            coords.Add(88257, new Point(1138, 69));

            // row 2
            coords.Add(87395, new Point(232,  212));
            coords.Add(88249, new Point(453,  212));
            coords.Add(92618, new Point(674,  212));
            coords.Add(88090, new Point(917,  212));
            coords.Add(88247, new Point(1138, 212));

            // row 3
            coords.Add(86259, new Point(232,  355));
            coords.Add(88191, new Point(453,  355));
            coords.Add(91996, new Point(674,  355));
            coords.Add(86936, new Point(917,  355));
            coords.Add(88250, new Point(1138, 355));

            // row 4
            coords.Add(86540, new Point(232, 542));
            coords.Add(95891, new Point(453, 542));
            coords.Add(87666, new Point(1030, 542));

            // row 5
            coords.Add(86968, new Point(232, 685));
            coords.Add(95775, new Point(453, 685));
            coords.Add(88089, new Point(1030, 685));
            coords.Add(99391, new Point(674, 685));

            // row 6
            coords.Add(86539, new Point( 232, 828));
            coords.Add(95807, new Point( 453, 828));
            coords.Add(86990, new Point( 917, 828));
            coords.Add(97568, new Point(1138, 828));
        }

        public MainFormEx()
        {
            createCoords();
            InitializeComponent();
            SuspendLayout();
            buildToolViewComponents();
            PerformLayout();
        }

        protected void buildToolViewComponents()
        {
            string queryString = "SELECT orderNumber, Заказы.ОбозначениеТО AS toolTitle, РаботникиЦеха_1.ФИО AS employeeName, РаботникиЦеха.ФИО AS workerName, status, Weight, NДетали, [date] FROM(РаботникиЦеха INNER JOIN(tblToolControl INNER JOIN Заказы ON tblToolControl.orderNumber = Заказы.NППЗаказа) ON РаботникиЦеха.NТабельный = Заказы.Технолог) INNER JOIN РаботникиЦеха AS РаботникиЦеха_1 ON Заказы.Слесарь = РаботникиЦеха_1.NТабельный";

            Cursor = Cursors.WaitCursor;
            using (OleDbConnection connection = new OleDbConnection(ToolControl.Properties.Settings.Default.connStr))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        ToolEntity toolEntity = new ToolEntity();
                        toolEntity.orderNumber = reader.GetInt32(0);
                        toolEntity.toolTitle = reader.GetString(1);
                        toolEntity.workerName = reader.GetString(2);
                        toolEntity.employeeName = reader.GetString(3);
                        toolEntity.status = reader.GetInt32(4);
                        if(!reader.IsDBNull(5))
                            toolEntity.weight = reader.GetInt32(5);

                        toolEntity.detailNumber = reader.GetString(6);

                        if (!reader.IsDBNull(7))
                            toolEntity.date = reader.GetDateTime(7);
                      
                        ToolView tv = new ToolView(toolEntity);
                        try
                        {
                            tv.Location = coords[toolEntity.orderNumber];
                        } catch 
                        {
                            MessageBox.Show(toolEntity.orderNumber.ToString());
                        }
                        Controls.Add(tv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                }
                reader.Close();
            }
            Cursor = Cursors.Default;
        }

        private void MainFormEx_Load(object sender, EventArgs e)
        {
            WindowState = Properties.Settings.Default.MainFormState;
            Location = Properties.Settings.Default.MainFormLocation;
            Size = Properties.Settings.Default.MainFormSize;
        }

        private void MainFormEx_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainFormState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // save location and size if the state is normal
                Properties.Settings.Default.MainFormLocation = this.Location;
                Properties.Settings.Default.MainFormSize = this.Size;
            }
            else
            {
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.MainFormLocation = this.RestoreBounds.Location;
                Properties.Settings.Default.MainFormSize = this.RestoreBounds.Size;
            }

            // don't forget to save the settings
            Properties.Settings.Default.Save();
        }
    }
}
