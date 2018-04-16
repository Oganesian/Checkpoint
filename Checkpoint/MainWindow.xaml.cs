using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Checkpoint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private int currentEmployeeID = -1;
        private string connectStr; // SQL Server Connection string
        public MainWindow()
        {
            InitializeComponent();
            employeesGrid.Items.Clear();
            reportsGrid.Items.Clear();
            allReportsGrid.Items.Clear();
        }

        private void Sign_In_Button_Click(object sender, RoutedEventArgs e) // Sign In 
        {
            connectStr = @"Database = Checkpoint; Data Source = localhost; User Id = " +
                loginBox.Text + "; Password =" + passwordBox.Password;
            AuthGrid.Visibility = Visibility.Collapsed;     // Hide "AuthGrid"
            MainGrid.Visibility = Visibility.Visible;       // Show "MainGrid"
            UpdateGrid("employees");
            UpdateGrid("report");
        }


        private void UpdateGrid(string TableName)
        {
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            DataGrid temp;
            if (TableName.Equals("employees"))
            {
                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset("SELECT * FROM employees", connectStr);
                temp = employeesGrid;
            }
            else
            {
                string SQLQuery =
                    @"SELECT report_IN.*, report_out.DateTime_OUT FROM `report_in`, `report_out` " +
                     "WHERE `report_out`.`Session_ID` = `report_in`.`Session_ID`";

                result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(SQLQuery, connectStr);
                temp = allReportsGrid;
            }

            if (result.HasError == false)
            {
                temp.ItemsSource = result.ResultData.DefaultView;  // Fill DataGrid with [updated] SQL Query return data
               
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        private void UpdateGrid(int ID)
        {
            string SQLQuery =
                   @"SELECT report_IN.*, report_out.DateTime_OUT FROM `report_in`, `report_out` " +
                    "WHERE `report_out`.`Session_ID` = `report_in`.`Session_ID` " +
                    "AND `report_in`.`ID` = " + ID;


            MySqlLib.MySqlData.MySqlExecuteData.MyResultData result = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();
            result = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(SQLQuery, connectStr);
            if (result.HasError == false)
            {
                reportsGrid.ItemsSource = result.ResultData.DefaultView;
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            if(employeesGrid.SelectedItem == null)
            {
                MessageBox.Show("Нажмите на строку с работником, которого хотите выбрать");
            }
            else
            {
                Int32.TryParse(((DataRowView)employeesGrid.SelectedItems[0]).Row["ID"].ToString(), out currentEmployeeID);
                tabControl.SelectedIndex = 1;
                UpdateGrid(currentEmployeeID);
            }
        }

        private void Update_Employee_Click(object sender, RoutedEventArgs e)
        {
            UpdateGrid("employees");
            UpdateGrid("report");
            UpdateGrid(1);
        }

        private void tabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (currentEmployeeID == -1 && tabControl.SelectedIndex == 1)
            {
                MessageBox.Show("Нажмите на строку с работником, которого хотите выбрать");
                tabControl.SelectedIndex = 0;
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Report_Input(true);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Report_Input(false);
        }

        private void Report_Input(bool enterInput)
        {
            DataGrid temp = new DataGrid();
            MySqlLib.MySqlData.MySqlExecuteData.MyResultData maxResult = new MySqlLib.MySqlData.MySqlExecuteData.MyResultData();

            string queryMaxInSession_ID = "SELECT MAX(Session_ID) FROM report_IN WHERE report_IN.ID = "
                + currentEmployeeID;

            string queryMaxOutSession_ID = "SELECT MAX(Session_ID) FROM report_OUT WHERE report_OUT.ID = "
                + currentEmployeeID;

            maxResult = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(queryMaxInSession_ID, connectStr);
            temp.ItemsSource = maxResult.ResultData.DefaultView;
            int maxInSession_ID;
            int.TryParse(((DataRowView)temp.Items[0]).Row["MAX(Session_ID)"].ToString(), out maxInSession_ID);

            maxResult = MySqlLib.MySqlData.MySqlExecuteData.SqlReturnDataset(queryMaxOutSession_ID, connectStr);
            temp.ItemsSource = maxResult.ResultData.DefaultView;
            int maxOutSession_ID;
            int.TryParse(((DataRowView)temp.Items[0]).Row["MAX(Session_ID)"].ToString(), out maxOutSession_ID);

            if (enterInput)
            {
                if(maxInSession_ID == maxOutSession_ID)
                {
                    Report_Input_SQL("IN", -1);
                }
                else // if maxInSession_ID > maxOutSession_ID then the entry is already committed
                {
                    MessageBox.Show("Вход работника уже зафиксирован");
                }
            }
            else
            {
                if (maxInSession_ID > maxOutSession_ID)
                {
                    Report_Input_SQL("OUT", maxInSession_ID);
                }
                else // if maxInSession_ID <= maxOutSession_ID then the entry isn't committed
                     // so they can't commit the exit
                {
                    MessageBox.Show("Вход работника не зафиксирован, поэтому нельзя зафиксировать выход");
                }
            }
        }

        private void Report_Input_SQL(string whichTable, int Session_ID)
        {
            string Session_ID_str = Session_ID == -1 ? "NULL" : "'"+Session_ID.ToString()+"'";

            MySqlLib.MySqlDataC.MySqlExecute.MyResult result = new MySqlLib.MySqlDataC.MySqlExecute.MyResult();
            string time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            result = MySqlLib.MySqlDataC.MySqlExecute.SqlNoneQuery("INSERT INTO report_" + whichTable + " VALUES('" +
                currentEmployeeID + "', '" + time + "', " + Session_ID_str + ")", connectStr);
            if (result.HasError == false)
            {
                UpdateGrid("report");
                UpdateGrid(currentEmployeeID);
            }
            else
            {
                MessageBox.Show(result.ErrorText);
            }
        }

        private void Search_Report_Click(object sender, RoutedEventArgs e)
        {
            SearchInReports search = new SearchInReports(connectStr, reportsGrid, currentEmployeeID);
            search.Show();
        }

        private void Search_All_Reports_Click(object sender, RoutedEventArgs e)
        {
            SearchInReports search = new SearchInReports(connectStr, allReportsGrid);
            search.Show();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchInOrAddEmployees window = new SearchInOrAddEmployees(employeesGrid, connectStr, true);
            window.Show();
        }

        private void Add_Employee_Click(object sender, RoutedEventArgs e)
        {
            SearchInOrAddEmployees window = new SearchInOrAddEmployees(employeesGrid, connectStr, false);
            window.Closed += new EventHandler(OnAddWindowClosing);
            window.Title = "Добавление работника";
            window.SearchOrAdd.Content = "Добавить";
            window.Show();
        }

        void OnAddWindowClosing(object sender, EventArgs e)
        {
            UpdateGrid("employees");
        }
    }
}
