using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Checkpoint
{
    /// <summary>
    /// Логика взаимодействия для SearchInReports.xaml
    /// </summary>
    public partial class SearchInReports
    {
        private string connectStr;
        private DataGrid grid;
        public SearchInReports(string connStr, DataGrid g)
        {
            InitializeComponent();
            connectStr = connStr;
            grid = g;
        }
        public SearchInReports(string connStr, DataGrid g, int id)
        {
            InitializeComponent();
            connectStr = connStr;
            grid = g;
            ID.IsEnabled = false;
            ID.Text = id.ToString();
        }

        private void OnlyDigits(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;     // Only digits can fill the box
        }

        private void Search_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string SQLQuery = "SELECT report_IN.*, report_out.DateTime_OUT FROM `report_in`, `report_out` WHERE " +
                "`report_out`.`Session_ID` = `report_in`.`Session_ID` AND ";
            TextBox[] textBoxes = { ID, Session_ID };
            string[] attributesHeaders = { "report_in.ID", "report_in.Session_ID" };
            for (int i = 0; i < 2; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text != "")
                    SQLQuery +=  attributesHeaders[i] + " = '" + textBoxes[i].Text + "' AND ";
            }
            if (Date_In.SelectedDate != null)
            {
                string dateTime = getDateTime(Date_In);
                SQLQuery += "`DateTime_In` = '" +
                   dateTime + "' AND ";
            }
            if(Date_Out.SelectedDate != null)
            {
                string dateTime = getDateTime(Date_Out);
                SQLQuery += "`DateTime_Out` = '" +
                   dateTime + "' AND ";
            }
            SQLQuery += "end";
            SQLQuery = SQLQuery.Replace(" AND end", "");
            if (!SQLQuery.Contains("end"))
            {
                MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(SQLQuery, connectStr);
                if (result.HasError == false)
                {
                    grid.ItemsSource = result.ResultData.DefaultView;
                    Close();
                }
                else
                {
                    MessageBox.Show(result.ErrorText);
                }
            }
            else
            {
                Close();
            }
        }

        string getDateTime(DateTimePicker picker)
        {
            string ret = "";

            ret += picker.SelectedDate.Value.Date.ToString("yyyy-MM-dd");
            ret += " ";
            ret += picker.SelectedTime.Value.Hours.ToString() + ":" +
                picker.SelectedTime.Value.Minutes.ToString() + ":" +
                picker.SelectedTime.Value.Seconds.ToString();

            return ret;
        }
    }
}
