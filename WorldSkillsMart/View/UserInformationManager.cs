using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WorldSkillsMart.Model;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class UserInformationManager : Form
    {
        public UserInformationManager()
        {
            InitializeComponent();
            AllClients = TakeAllClients();
            UserDataGridView.DataSource = AllClients;
        }

        private List<Client> _allClients;
        public List<Client> AllClients
        {
            get
            {
                return _allClients;
            }
            set
            {
                _allClients = value;
            }
        }

        private Client _selectedClient;
        public Client SelectedClient
        {
            get
            {
                return _selectedClient;
            }
            set
            {
                _selectedClient = value;
                IdTextBox.Text = _selectedClient.ID.ToString();
                UserRoleTextBox.Text = _selectedClient.Role;
                LoginUserTextBox.Text = _selectedClient.Login;
                PasswordUserTextBox.Text = _selectedClient.Password;
                ConfirmedUserTextBox.Text = _selectedClient.Confirmed.ToString();
            }
        }

        private List<Client> TakeAllClients()
        {
            List<Client> client = new List<Client>();
            DatabaseManager.SqlCommand.CommandText = "SELECT * FROM [Client]";
            SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
            while (reader.Read())
            {
                client.Add(new Client { ID = int.Parse(reader.GetValue(0).ToString()), Role = reader.GetValue(1).ToString(), Login = reader.GetValue(2).ToString(), Password = reader.GetValue(3).ToString(), LastOnline = DateTime.Parse(reader.GetValue(4).ToString()), LastPasswordUpdate = DateTime.Parse(reader.GetValue(5).ToString()), Confirmed = bool.Parse(reader.GetValue(6).ToString()) });
            }
            reader.Close();
            return client;
        }

        private void UserDataGridViewSelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UserDataGridView.SelectedRows)
            {
                int value1 = int.Parse(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                string value3 = row.Cells[2].Value.ToString();
                string value4 = row.Cells[3].Value.ToString();
                DateTime value5 = DateTime.Parse(row.Cells[4].Value.ToString());
                DateTime value6 = DateTime.Parse(row.Cells[5].Value.ToString());
                bool value7 = bool.Parse(row.Cells[6].Value.ToString());
                SelectedClient = new Client { ID = value1, Role = value2, Login = value3, Password = value4, LastOnline = value5, LastPasswordUpdate = value6, Confirmed = value7 };
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            DatabaseManager.SqlCommand.CommandText = $"DELETE Client WHERE ID = {IdTextBox.Text}";
            int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
            if (update == 1)
            {
                MessageBox.Show("Аккаунт был удален.");
                AllClients = TakeAllClients();
                UserDataGridView.DataSource = AllClients;
            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            DatabaseManager.SqlCommand.CommandText = $"UPDATE Client SET Role = '{UserRoleTextBox.Text}', Login = '{LoginUserTextBox.Text}', Password = '{PasswordUserTextBox.Text}', Confirmed = '{ConfirmedUserTextBox.Text}' WHERE ID = {SelectedClient.ID}"; 
            int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
            if (update == 1)
            {
                MessageBox.Show("Аккаунт был изменен.");
                AllClients = TakeAllClients();
                UserDataGridView.DataSource = AllClients;
            }
        }

        private void InsertButtonClick(object sender, EventArgs e)
        {
            DateTime LastOnline = DateTime.Parse(NewOnlineUserTextBox.Text);
            DateTime PassportUpdate = DateTime.Parse(NewPasswordUpdateUserTextBox.Text);
            DatabaseManager.SqlCommand.CommandText = $"INSERT INTO Client (Role, Login, Password, LastOnline, LastPasswordUpdate, Confirmed) VALUES  ('{NewRoleUserTextBox.Text}', '{NewLoginUserTextBox.Text}', '{NewPasswordUserTextBox.Text}', '{LastOnline:MM/dd/yyyy}', '{PassportUpdate:MM/dd/yyyy}', '{NewConfirmedUserTextBox.Text}')";
            int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
            if (update == 1)
            {
                MessageBox.Show("Аккаунт был добавлен.");
                AllClients = TakeAllClients();
                UserDataGridView.DataSource = AllClients;
            }
        }
    }
}
