using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



        private List<Client> TakeAllClients()
        {
            List<Client> client = new List<Client>();
            DatabaseManager.SqlCommand.CommandText = "SELECT * FROM [Client]";
            SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
            while (reader.Read())
            {
                client.Add(new Client { ID = int.Parse(reader.GetValue(0).ToString()), Role = reader.GetValue(1).ToString(), Login = reader.GetValue(2).ToString(), Password = reader.GetValue(3).ToString(), LastOnline = DateTime.Parse(reader.GetValue(4).ToString()), LastPasswordUpdate = DateTime.Parse(reader.GetValue(5).ToString()), Confirmed = bool.Parse(reader.GetValue(6).ToString()) });
            }
            return client;
        }
    }
}
