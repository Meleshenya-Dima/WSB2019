using System;
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
            SalesPersonGridView.DataSource = GetSalesPerson();
        }

        private Boat _boat;

        public Boat SelectedBoat
        {
            get
            {
                return _boat;
            }
            set
            {
                _boat = value;

                textBox1.Text = _boat.Model;
                textBox2.Text = _boat.BoatType;
                textBox4.Text = _boat.Color;
                textBox3.Text = _boat.Wood;
            }
        }

        private SalesPerson _selectedSalesPerson;

        public SalesPerson SelectedSalesPerson
        {
            get
            {
                return _selectedSalesPerson;
            }
            set
            {
                _selectedSalesPerson = value;
            }
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
            reader.Close();
            return boats;
        }

        private List<SalesPerson> GetSalesPerson()
        {
            List<SalesPerson> salesPeople = new List<SalesPerson>();
            DatabaseManager.SqlCommand.CommandText = "SELECT * FROM [SalesPerson]";
            SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
            while (reader.Read())
            {
                salesPeople.Add(new SalesPerson {SalesPerson_ID = int.Parse(reader.GetValue(0).ToString()), FirstName = reader.GetValue(1).ToString(), FamilyName = reader.GetValue(2).ToString()});
            }
            reader.Close();
            return salesPeople;
        }

        private void BoatGridViewSelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BoatGridView.SelectedRows)
            {
                int value1 = int.Parse(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                string value3 = row.Cells[2].Value.ToString();
                int value4 = int.Parse(row.Cells[3].Value.ToString());
                bool value5 = bool.Parse(row.Cells[4].Value.ToString());
                string value6 = row.Cells[5].Value.ToString();
                string value7 = row.Cells[6].Value.ToString();
                float value8 = float.Parse(row.Cells[7].Value.ToString());
                int value9 = int.Parse(row.Cells[8].Value.ToString());
                SelectedBoat = new Boat { Boat_ID = value1, Model = value2, BoatType = value3, NumberOfRowers = value4, Mast = value5, Color = value6, Wood = value7, BasePrice = value8, VAT = value9};
            }
        }


        private void SalesPersonGridViewSelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in BoatGridView.SelectedRows)
            {
                int value1 = int.Parse(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                string value3 = row.Cells[2].Value.ToString();
                SelectedSalesPerson = new SalesPerson {SalesPerson_ID= value1, FirstName = value2, FamilyName = value3};
            }
        }

        private void CreateOrderButtonClick(object sender, EventArgs e)
        {
            DatabaseManager.SqlCommand.CommandText = "INSERT INTO [Order] (Order_ID, Date, Salesperson_ID, Customer_ID, Boat_ID, DeliveryAddress, City) VALUES ()";
            DatabaseManager.SqlCommand.ExecuteReader();
        }
    }
}
