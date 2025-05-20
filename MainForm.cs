using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ToolControl
{
    public partial class MainForm : Form
    {
        List<ToolEntity> list = new List<ToolEntity>();

        protected void fillToolEntityList()
        {
            list.Clear();
            string queryString = "SELECT orderNumber, Заказы.ОбозначениеТО AS toolTitle, РаботникиЦеха_1.ФИО AS employeeName, РаботникиЦеха.ФИО AS workerName, status FROM(РаботникиЦеха INNER JOIN(tblToolControl INNER JOIN Заказы ON tblToolControl.orderNumber = Заказы.NППЗаказа) ON РаботникиЦеха.NТабельный = Заказы.Технолог) INNER JOIN РаботникиЦеха AS РаботникиЦеха_1 ON Заказы.Слесарь = РаботникиЦеха_1.NТабельный";

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
                        toolEntity.employeeName = reader.GetString(2);
                        toolEntity.workerName = reader.GetString(3);
                        toolEntity.status = reader.GetInt32(4);
                        list.Add(toolEntity);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                }
                reader.Close();
            }
            Cursor = Cursors.Default;
        }

        public MainForm()
        {
            InitializeComponent();
            fillToolEntityList();

            foreach(ToolEntity te in list)
            {
                layout.Controls.Add(new ToolView(te));
            }

        }
    }
}
