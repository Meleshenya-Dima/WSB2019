using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkillsMart.View
{
    public partial class AdministratorPanel : Form
    {
        public AdministratorPanel()
        {
            InitializeComponent();
        }

        private void UserManagerButtonClick(object sender, EventArgs e)
        {
            UserInformationManager userInformationManager = new UserInformationManager();
            this.Hide();
            userInformationManager.ShowDialog();
            this.Show();
        }

        private void ProductManagerButtonClick(object sender, EventArgs e)
        {
            ProductionManagement productionManagement = new ProductionManagement();
            this.Hide();
            productionManagement.ShowDialog();
            this.Show();
        }
    }
}
