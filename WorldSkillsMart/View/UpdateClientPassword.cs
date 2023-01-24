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
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class UpdateClientPassword : Form
    {
        public UpdateClientPassword()
        {
            InitializeComponent();
        }

        private void UpdatePasswordButtonClick(object sender, EventArgs e)
        {
            if (PasswordTextNow.Text == StaticClientInformation.Client.Password && NewPasswordText.Text == NewPasswordTextSecond.Text)
            {
                StaticClientInformation.Client.Password = NewPasswordText.Text;
                DatabaseManager.SqlCommand.CommandText = $"UPDATE Client SET Password = '{NewPasswordText.Text}', LastPasswordUpdate = '{DateTime.Now:MM/dd/yyyy}', LastOnline = '{DateTime.Now:MM/dd/yyyy}' WHERE ID = {StaticClientInformation.Client.ID}";
                int isAdd = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (isAdd == 1)
                {
                    Authorization.IsUpdate = true;
                    MessageBox.Show("Пароль обнавлен!");
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста проверьте ещё раз введенные данные");
                }

            }
            else
            {
                MessageBox.Show("Старый пароль не совпадает или новые не совпадает!");
            }
        }
    }
}
