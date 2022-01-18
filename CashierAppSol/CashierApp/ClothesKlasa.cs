using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class ClothesKlasa:BaznaKlasa,IClothesKlasa
    {
        private string _Size;
        private string _Color;
        public string Size
        {
            get { return _Size; }
            set {
                if (value == "XS" || value == "S" || value=="M" || value=="L" || value =="XL" || value=="XXL" || value == "XXXL" || value== "XXXXL") { 
                _Size = value;
                
                }
                else
                {
                    throw new Exception("Greska!");
                }
            }
        }
        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }
        public new string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public new int price
        {
            get { return _price; }
            set
            {
                if (value > 0.99)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("Cena mora biti veca od nule!");
                }
            }


        }
        public new string brend
        {
            get { return _brend; }
            set { _brend = value; }
        }
        public int Discount_Clothes(int val)
        {
            double Perc;


            bool day1 = experationDate.DayOfWeek == DayOfWeek.Monday;
            bool day2 = experationDate.DayOfWeek == DayOfWeek.Tuesday;

            bool day3 = experationDate.DayOfWeek == DayOfWeek.Wednesday;

            bool day4 = experationDate.DayOfWeek == DayOfWeek.Thursday;

            bool day5 = experationDate.DayOfWeek == DayOfWeek.Friday;
            if (price >999)
            {
                Perc = 0.05;
                val = (int)(price * Perc);


            }

            else if (day1 || day2|| day3 || day4 || day5 == true)
            {
                Perc = 0.1;
                val =(int)(price * Perc);
            }


            return val;
        }
    }
}
