using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WorldSkillsMart.Model;
using WorldSkillsMart.ViewModel;

namespace WorldSkillsMart.View
{
    public partial class ProductionManagement : Form
    {
        public ProductionManagement()
        {
            InitializeComponent();
        }

        private string _production = "";

        private List<Boat> _boats;
        public List<Boat> BoatsProduct
        {
            get
            {
                return _boats;
            }
            set
            {
                _boats = value;
            }
        }

        private List<Accessory> _accessory;
        public List<Accessory> AccessoryProduct
        {
            get
            {
                return _accessory;
            }
            set
            {
                _accessory = value;
            }
        }


        private Boat _selectedBoat;
        public Boat SelectedBoat
        {
            get
            {
                return _selectedBoat;
            }
            set
            {
                _selectedBoat = value;

                IdTextBox.Text = _selectedBoat.Boat_ID.ToString();
                textBox1.Text = _selectedBoat.Model;
                textBox2.Text = _selectedBoat.BoatType;
                textBox3.Text = _selectedBoat.NumberOfRowers.ToString();
                textBox4.Text = _selectedBoat.Mast.ToString();
                textBox5.Text = _selectedBoat.Color;
                textBox6.Text = _selectedBoat.Wood;
                textBox7.Text = _selectedBoat.BasePrice.ToString();
                textBox8.Text = _selectedBoat.VAT.ToString();
            }
        }

        private Accessory _selectedAccessory;
        public Accessory SelectedAccessory
        {
            get
            {
                return _selectedAccessory;
            }
            set
            {
                _selectedAccessory = value;

                IdTextBox.Text = _selectedAccessory.Accessory_ID.ToString();
                textBox1.Text = _selectedAccessory.AccName;
                textBox2.Text = _selectedAccessory.DescriptionOfAccessory;
                textBox3.Text = _selectedAccessory.Price.ToString();
                textBox4.Text = _selectedAccessory.VAT.ToString();
                textBox5.Text = _selectedAccessory.Inventory.ToString();
                textBox6.Text = _selectedAccessory.OrderLevel.ToString();
                textBox7.Text = _selectedAccessory.OrderBatch.ToString();
                textBox8.Text = _selectedAccessory.Partner_ID.ToString();
            }
        }

        private void AccessoryLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _production = "Accessory";
            TakeProduction();
        }

        private void BoatLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _production = "Boat";
            TakeProduction();
        }

        private void TakeProduction()
        {
            if (_production == "Accessory")
            {
                List<Accessory> accessories = new List<Accessory>();
                DatabaseManager.SqlCommand.CommandText = $"SELECT * FROM [Accessory] ";
                DatabaseManager.SqlCommand.Connection = DatabaseManager.SqlConnection;
                SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    accessories.Add(new Accessory { Accessory_ID = int.Parse(reader.GetValue(0).ToString()), AccName = reader.GetValue(1).ToString(), DescriptionOfAccessory = reader.GetValue(2).ToString(), Price = float.Parse(reader.GetValue(3).ToString()), VAT = float.Parse(reader.GetValue(4).ToString()), Inventory = int.Parse(reader.GetValue(5).ToString()), OrderLevel = int.Parse(reader.GetValue(6).ToString()), OrderBatch = int.Parse(reader.GetValue(7).ToString()), Partner_ID = int.Parse(reader.GetValue(8).ToString()) });
                }
                reader.Close();
                AccessoryProduct = accessories;
                dataGridView.DataSource = AccessoryProduct;
            }
            else
            {
                List<Boat> boat = new List<Boat>();
                DatabaseManager.SqlCommand.CommandText = $"SELECT * FROM [Boat] ";
                DatabaseManager.SqlCommand.Connection = DatabaseManager.SqlConnection;
                SqlDataReader reader = DatabaseManager.SqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    boat.Add(new Boat { Boat_ID = int.Parse(reader.GetValue(0).ToString()), Model = reader.GetValue(1).ToString(), BoatType = reader.GetValue(2).ToString(), NumberOfRowers = int.Parse(reader.GetValue(3).ToString()), Mast = bool.Parse(reader.GetValue(4).ToString()), Color = reader.GetValue(5).ToString(), Wood = reader.GetValue(6).ToString(), BasePrice = float.Parse(reader.GetValue(7).ToString()), VAT = int.Parse(reader.GetValue(8).ToString()) });
                }
                reader.Close();
                BoatsProduct = boat;
                dataGridView.DataSource = BoatsProduct;
            }
        }

        private void ProductionDataGridViewSelectionChanged(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                int value1 = int.Parse(row.Cells[0].Value.ToString());
                string value2 = row.Cells[1].Value.ToString();
                string value3 = row.Cells[2].Value.ToString();
                string value4 = row.Cells[3].Value.ToString();
                string value5 = row.Cells[4].Value.ToString();
                string value6 = row.Cells[5].Value.ToString();
                string value7 = row.Cells[6].Value.ToString();
                string value8 = row.Cells[7].Value.ToString();
                int value9 = int.Parse(row.Cells[8].Value.ToString());

                if (_production == "Accessory")
                {
                    SelectedAccessory = new Accessory { Accessory_ID = value1, AccName = value2, DescriptionOfAccessory = value3, Price = float.Parse(value4), VAT = float.Parse(value5), Inventory = int.Parse(value6), OrderLevel = int.Parse(value7), OrderBatch = int.Parse(value8), Partner_ID = value9 };
                }
                else
                {
                    SelectedBoat = new Boat { Boat_ID = value1, Model = value2, BoatType = value3, NumberOfRowers = int.Parse(value4), Mast = bool.Parse(value5), Color = value6, Wood = value7, BasePrice = float.Parse(value8), VAT = value9 };
                }
            }
        }

        private void DeleteButtonClick(object sender, System.EventArgs e)
        {
            if (_production == "Accessory")
            {
                DatabaseManager.SqlCommand.CommandText = $"DELETE [Accessory] WHERE Accessory_ID = {IdTextBox.Text}";
                int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (update == 1)
                {
                    MessageBox.Show("Аккаунт был удален.");
                    TakeProduction();
                    dataGridView.DataSource = AccessoryProduct;
                }
            }
            else
            {
                DatabaseManager.SqlCommand.CommandText = $"DELETE [Boat] WHERE Boat_ID = {IdTextBox.Text}";
                int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (update == 1)
                {
                    MessageBox.Show("Аккаунт был удален.");
                    TakeProduction();
                    dataGridView.DataSource = BoatsProduct;
                }
            }
        }

        private void UpdateButtonClick(object sender, System.EventArgs e)
        {
            if (_production == "Accessory")
            {
                DatabaseManager.SqlCommand.CommandText = $"UPDATE Accessory SET AccName = '{textBox1.Text}', DescriptionOfAccessory = '{textBox2.Text}', Price = {textBox3.Text}, VAT = {textBox4.Text}, Inventory = {textBox5.Text}, OrderLevel = {textBox6.Text}, OrderBatch = {textBox7.Text}, Partner_ID = {textBox8.Text} WHERE Accessory_ID = {SelectedAccessory.Accessory_ID}";
                int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (update == 1)
                {
                    MessageBox.Show("Продукция была обновлена.");
                    TakeProduction();
                    dataGridView.DataSource = AccessoryProduct;
                }
            }
            else
            {
                DatabaseManager.SqlCommand.CommandText = $"UPDATE Boat SET Model = '{textBox1.Text}', BoatType = '{textBox2.Text}', NumberOfRowers = {textBox3.Text}, Mast = {textBox4.Text}, Colour = {textBox5.Text}, Wood = {textBox6.Text}, BasePrice = {textBox7.Text}, VAT = {textBox8.Text} WHERE Boat_ID = {SelectedAccessory.Accessory_ID}";
                int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (update == 1)
                {
                    MessageBox.Show("Продукция была обновлена.");
                    TakeProduction();
                    dataGridView.DataSource = AccessoryProduct;
                }
            }
        }

        private void InsertButtonClick(object sender, System.EventArgs e)
        {
            if (_production == "Accessory")
            {
                DatabaseManager.SqlCommand.CommandText = $"INSERT INTO [Accessory] (AccName, DescriptionOfAccessory, Price, VAT, Inventory, OrderLevel, OrderBatch, Partner_ID) VALUES ('{textBox16.Text}', '{textBox15.Text}', {textBox14.Text}, {textBox13.Text}, {textBox12.Text}, '{textBox11.Text}', {textBox10.Text}, {textBox9.Text})";
                int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (update == 1)
                {
                    MessageBox.Show("Продукция была добавлена.");
                    TakeProduction();
                    dataGridView.DataSource = AccessoryProduct;
                }
            }
            else
            {
                DatabaseManager.SqlCommand.CommandText = $"INSERT INTO [Boat] (Model, BoatType, NumberOfRowers, Mast, Colour, Wood, BasePrice, VAT) VALUES ('{textBox16.Text}', '{textBox15.Text}', {textBox14.Text}, '{textBox13.Text}', '{textBox12.Text}', '{textBox11.Text}', {textBox10.Text}, {textBox9.Text})";
                int update = DatabaseManager.SqlCommand.ExecuteNonQuery();
                if (update == 1)
                {
                    MessageBox.Show("Продукция была добавлена.");
                    TakeProduction();
                    dataGridView.DataSource = AccessoryProduct;
                }
            }
        }
    }
}
