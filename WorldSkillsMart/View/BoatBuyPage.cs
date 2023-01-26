using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WorldSkillsMart.Model;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class BoatBuyPage : Form
    {
        public BoatBuyPage()
        {
            InitializeComponent();
            BoatGridView.DataSource = SelectAllBoatInDatabase();
        }


        private List<Boat> SelectAllBoatInDatabase()
        {
            List<Boat> boats = new List<Boat>();
            DatabaseManager.SqlCommand.CommandText = "SELECT * FROM [Boat]";
            SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
            while (reader.Read())
            {
                boats.Add(new Boat { Boat_ID = int.Parse(reader.GetValue(0).ToString()), Model = reader.GetValue(1).ToString(), BoatType = reader.GetValue(2).ToString(), NumberOfRowers = int.Parse(reader.GetValue(0).ToString()) , Mast = bool.Parse(reader.GetValue(4).ToString()), Color = reader.GetValue(5).ToString(), Wood = reader.GetValue(6).ToString(), BasePrice = float.Parse(reader.GetValue(7).ToString()), VAT = int.Parse(reader.GetValue(8).ToString())});
            }
            return boats;
        }
    }
}
