using System;
using System.Windows;
using System.Windows.Controls;

namespace Checkpoint
{
    /// <summary>
    /// Логика взаимодействия для SearchInEmployees.xaml
    /// </summary>
    public partial class SearchInOrAddEmployees
    {
        string connectStr;
        DataGrid grid;
        bool Search; // true - search, false - add
        public SearchInOrAddEmployees(DataGrid grid, string connStr, bool search)
        {
            InitializeComponent();
            connectStr = connStr;
            this.grid = grid;
            Search = search;
        }

        private void OnlyDigits(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;     // Only digits can fill the box
        }

        private void SearchOrAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Search)
            {
                SearchEmployee();
            }
            else
            {
                AddEmployee();
            }
        }

        private void AddEmployee()
        {
            string SQLQuery = "INSERT INTO employees VALUES(";
            TextBox[] textBoxes = { ID, FullName, Passport, Organization };
            string[] attributesHeaders = { "ID", "Full_Name", "Serial_And_Passport_Number", "Organization" };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text != "")
                    SQLQuery += "'" + textBoxes[i].Text + "', ";
            }
            if (ConfirmedByTheOrganization.SelectedIndex != -1)
            {
                SQLQuery += "'" + ConfirmedByTheOrganization.SelectedIndex + "')";
            }
            MySqlLib.MySqlDataC.MySqlExecute.MyResult result = new MySqlLib.MySqlDataC.MySqlExecute.MyResult();
            result = MySqlLib.MySqlDataC.MySqlExecute.SqlNoneQuery(SQLQuery, connectStr);
            if (result.HasError == false)
            {
                Close();
            }
            else
            {
                MessageBox.Show(result.ErrorText);
                MessageBox.Show(SQLQuery);
            }
        }
        private void SearchEmployee()
        {
            string SQLQuery = "SELECT * FROM employees WHERE ";
            TextBox[] textBoxes = { ID, FullName, Passport, Organization };
            string[] attributesHeaders = { "ID", "Full_Name", "Serial_And_Passport_Number", "Organization" };
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text != null && textBoxes[i].Text != "")
                    SQLQuery += "`" + attributesHeaders[i] + "` = '" + textBoxes[i].Text + "' AND ";
            }
            if (ConfirmedByTheOrganization.SelectedIndex != -1)
            {
                SQLQuery += "`Confirmed_By_The_Organization` = '" +
                    ConfirmedByTheOrganization.SelectedIndex + "'";
            }
            SQLQuery += "end";
            SQLQuery = SQLQuery.Replace(" AND end", "");
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
                MessageBox.Show(SQLQuery);
            }
        }
    }
}
