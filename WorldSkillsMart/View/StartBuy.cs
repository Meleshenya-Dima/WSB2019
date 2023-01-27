using System;
using System.Windows.Forms;

namespace WorldSkillsMart.View
{
    public partial class StartBuy : Form
    {
        public StartBuy()
        {
            InitializeComponent();
        }

        private void BoatToolStripMenuItemClick(object sender, EventArgs e)
        {
            BoatBuyPage boatBuyPage = new BoatBuyPage();
            boatBuyPage.ShowDialog();
        }

        private void AccessoriesToolStripMenuItemClick(object sender, EventArgs e)
        {

        }
    }
}
