using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WorldSkillsMart.Model;
using WorldSkillsMart.View;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            DatabaseManager.OpenSqlConnection();
            Timer.Tick += TimerTick;
        }
        private int _timeTimerTick = 15;
        private int _timeTimerTickNow = 0;
        private static bool _isUpdate = false;


        private int _countAuth = 0;
        public int CountAuth
        {
            get
            {
                return _countAuth;
            }
            set
            {
                if (value == 4)
                {
                    _countAuth = 0;
                    Timer.Start();
                    NameUser.Enabled = false;
                    PasswordUser.Enabled = false;
                }
                else
                {
                    _countAuth += value;
                }
            }
        }
        public static bool IsUpdate
        {
            get
            {
                return _isUpdate;
            }
            set
            {
                IsUpdate = value;
            }
        }

        private void AuthorizationButtonClick(object sender, EventArgs e)
        {
            string name = NameUser.Text;
            string password = PasswordUser.Text;
            DatabaseManager.SqlCommand.CommandText = $"SELECT * FROM [Client] WHERE Login = '{name}' AND Password = '{password}'";
            DatabaseManager.SqlCommand.Connection = DatabaseManager.SqlConnection;
            SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
            if (reader.Read())
            {

                StaticClientInformation.Client = new Client { ID = int.Parse(reader.GetValue(0).ToString()), Role = reader.GetValue(1).ToString(), Login = reader.GetValue(2).ToString(), Password = reader.GetValue(3).ToString(), LastOnline = DateTime.Parse(reader.GetValue(4).ToString()), LastPasswordUpdate = DateTime.Parse(reader.GetValue(5).ToString()) };
                if ((DateTime.Now - StaticClientInformation.Client.LastOnline).TotalDays >= 30)
                {
                    reader.Close();
                    MessageBox.Show("Аккаунт был забанен из-за количества дней вашего отсутсвия, а именно более 30!");
                }
                else if ((DateTime.Now - StaticClientInformation.Client.LastPasswordUpdate).TotalDays >= 14)
                {
                    reader.Close();
                    UpdateClientPassword updateClientPassword = new UpdateClientPassword();
                    updateClientPassword.ShowDialog();
                }
                else
                {
                    DatabaseManager.SqlCommand.CommandText = $"UPDATE Client SET LastOnline = '{DateTime.Now:MM/dd/yyyy}' WHERE ID = {StaticClientInformation.Client.ID}";
                    DatabaseManager.SqlCommand.ExecuteNonQuery();
                    IsUpdate = true;
                }
            }
            else
            {
                reader.Close();
                CountAuth++;
                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
            }

            if (IsUpdate)
            {
                if (StaticClientInformation.Client.Role == "User")
                {

                }
                else
                {

                }
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimerInformation.Text = _timeTimerTickNow.ToString();
            _timeTimerTickNow++;
            if (_timeTimerTickNow == _timeTimerTick)
            {
                _timeTimerTick += 20;
                _timeTimerTickNow = 0;
                NameUser.Enabled = true;
                PasswordUser.Enabled = true;
                Timer.Stop();
                TimerInformation.Text = "";
            }
        }

        private void OpenRegisterFormButtonClick(object sender, EventArgs e)
        {
            Register authorizationPage = new Register();
            authorizationPage.ShowDialog();
        }
    }
}
