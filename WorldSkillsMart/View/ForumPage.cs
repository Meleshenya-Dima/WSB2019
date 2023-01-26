using System.Diagnostics;
using System.Windows.Forms;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/Meleshenya-Dima");
            //Process.Start(sInfo);
        }

        private void StartBuyButtonClick(object sender, System.EventArgs e)
        {
            StartBuy startBuy = new StartBuy();
            startBuy.ShowDialog();
        }
    }
}
