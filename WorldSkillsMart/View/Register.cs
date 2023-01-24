using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButtonClick(object sender, EventArgs e)
        {
            string loginUser = NameUser.Text;
            string passwordUser = PasswordUser.Text;

            if (passwordUser == RepeatPasswordUser.Text)
            {
                DatabaseManager.SqlCommand.CommandText = $"SELECT * FROM [Client] WHERE Login = '{loginUser}' AND Password = '{passwordUser}'";
                DatabaseManager.SqlCommand.Connection = DatabaseManager.SqlConnection;
                SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Данный пользователь уже существует, введите другие данные или попробуйте авторизоваться!");
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    DatabaseManager.SqlCommand.CommandText = $"INSERT INTO [Client] (Role, Login, Password, LastOnline, LastPasswordUpdate) VALUES ('User', '{loginUser}', '{passwordUser}', '{DateTime.Now:MM/dd/yyyy}', '{DateTime.Now:MM/dd/yyyy}')";
                    int isAdd = DatabaseManager.SqlCommand.ExecuteNonQuery();
                    if (isAdd == 1)
                    {
                        MessageBox.Show("Пользователь добавлен!");
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
                    }
                }
            }
        }
    }
}
