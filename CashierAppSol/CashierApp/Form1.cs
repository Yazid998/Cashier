using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp
{
    public partial class Form1 : Form
    {
        List<FoodKlasa> FoodKlasas = new List<FoodKlasa>();
        FoodKlasa Food = new FoodKlasa();

        List<BeverageKlasa> BeverageKlasas = new List<BeverageKlasa>();
        BeverageKlasa Beverage = new BeverageKlasa();


        public Form1()
        {
            InitializeComponent();
        }
        public void ListFood()
        {
            listBox1.Items.Clear();

            foreach (FoodKlasa s in FoodKlasas)
            {

                listBox1.Items.Add(s.name);
                listBox1.Items.Add(s.price);
                listBox1.Items.Add(s.brend);
                listBox1.Items.Add(s.experationDate);
                

            }

        }
        public void ListBeverage()
        {
            foreach (BeverageKlasa b in BeverageKlasas)
            {

                listBox1.Items.Add(b.name);
                listBox1.Items.Add(b.price);
                listBox1.Items.Add(b.brend);
                listBox1.Items.Add(b.experationDate);
            }
            
        }
        private void Recepit_Click(object sender, EventArgs e)
        {
            try { 
                //Food
                Food.name = "apples";
               
                Food.price = 2;
                Food.brend = "BrendA";
                Food.experationDate = new DateTime(2021,06,14);
                MessageBox.Show(Food.name);
                MessageBox.Show(Food.Discount(Food._price).ToString());
                MessageBox.Show(Food.experationDate.ToString());

                MessageBox.Show(Food.price.ToString());
                //Beverage
                Beverage.name = "Milk";
                Beverage.price = 1;
                Beverage.brend = "BrendM";
                Beverage.experationDate = new DateTime(2022, 02, 02);
                MessageBox.Show(Beverage.name);
                MessageBox.Show(Beverage.price.ToString());
                MessageBox.Show(Beverage.brend);
                MessageBox.Show(Beverage.experationDate.ToString());
                //Clothes
                ClothesKlasa clothes = new ClothesKlasa();
                clothes.name = "T-Shirt";
                clothes.price = 16;
                clothes.brend = "BrandT";
                clothes.Size = "M";
                clothes.Color = "Violent";
                MessageBox.Show(clothes.name);
                MessageBox.Show(clothes.price.ToString());
                MessageBox.Show(clothes.brend);
                //Notice: This is just a normal date(it can acts)... i am accidentally put the experation date with the clothes
                MessageBox.Show(clothes.experationDate.ToString());
                MessageBox.Show(clothes.Discount_Clothes(clothes.price).ToString());
                MessageBox.Show(clothes.Size);
                MessageBox.Show(clothes.Color);
                //Appiliance
                ApplianceKlasa appiliance = new ApplianceKlasa();
                appiliance.name = "Laptop";
                appiliance.brend = "BrandL";
                appiliance.price = 2345;
                appiliance.Model = "ModelL";
                appiliance.ProductionDate = new DateTime(2021, 03, 03);
                appiliance.Weight = 1;
                MessageBox.Show(appiliance.name);
                MessageBox.Show(appiliance.price.ToString());
                MessageBox.Show(appiliance.brend);
                MessageBox.Show(appiliance.Model);
                MessageBox.Show(appiliance.ProductionDate.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
