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
