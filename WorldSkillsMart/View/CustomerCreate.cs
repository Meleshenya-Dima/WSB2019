using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class CustomerCreate : Form
    {
        private string _emailUser;
        private string _passwordUser;
        public CustomerCreate(string email, string password)
        {
            _emailUser = email;
            _passwordUser = password;
            InitializeComponent();
        }

        private void EndRegisterButtonClick(object sender, EventArgs e)
        {
            string nameUser = textBox1.Text;
            string familyNameUser = textBox2.Text;
            string dateBirthday = textBox3.Text;
            string address = textBox4.Text;
            string city = textBox5.Text;
            string number = textBox6.Text;
            string numberID = textBox7.Text;
            string numberDocument = textBox8.Text;
            string organisationName = textBox9.Text;
            if (!string.IsNullOrEmpty(nameUser) && !string.IsNullOrEmpty(familyNameUser) && !string.IsNullOrEmpty(dateBirthday) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(number) && !string.IsNullOrEmpty(numberID) && !string.IsNullOrEmpty(numberDocument))
            {
                DatabaseManager.SqlCommand.CommandText = $"INSERT INTO [Customer] (FistName, FamilyName, DateOfBirth, OrganisationName, Address, City, Email, Phone, IDNumber, IDDocumentName) VALUES ('{nameUser}', '{familyNameUser}', '{dateBirthday}', '{organisationName}', '{address}', '{city}', '{_emailUser}','{number}', '{numberID}', '{numberDocument}')";
                int isAdd = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (isAdd == 1)
                {
                    isAdd = 0;
                    DatabaseManager.SqlCommand.CommandText = $"INSERT INTO [Client] (Role, Login, Password, LastOnline, LastPasswordUpdate) VALUES ('User', '{_emailUser}', '{_passwordUser}', '{DateTime.Now:MM/dd/yyyy}', '{DateTime.Now:MM/dd/yyyy}', 'False')";
                    isAdd = DatabaseManager.SqlCommand.ExecuteNonQuery();
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
