﻿using System.Windows.Forms;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class ForumPage : Form
    {
        public ForumPage()
        {
            InitializeComponent();
            if (StaticClientInformation.Client.Role == "Administrator")
            {
                AdminPanelButton.Visible = true;
            }
        }

        private void AdminPanelButtonClick(object sender, System.EventArgs e)
        {
            AdministratorPanel administratorPanel = new AdministratorPanel();
            this.Hide();
            administratorPanel.ShowDialog();
            this.Show();
        }
    }
}
