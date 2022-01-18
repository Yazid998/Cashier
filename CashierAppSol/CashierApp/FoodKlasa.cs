using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class FoodKlasa:BaznaKlasa,IFoodKlasa
    {
       
       
        public new string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public new int price
        {
            get { return _price; }
            set { 
                if(value > 0.99) {   
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
        public new DateTime experationDate
        {
            get { return _experation_date; }
            set
            {
                if (value.Year > 1900 && value.Year <= DateTime.Today.Year)
                {
                    _experation_date = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
      
        public int Discount(int val)
        {
            double Perc;
           // DateTime date2 = experationDate.AddDays(-5);
            //bool date3 = Convert.ToBoolean(date2);
          
            if (experationDate == experationDate)
            {
                Perc = 0.5;
                val= (int)(price * Perc);


            }

          //  else if(date3== true)
         //   {
          //      Perc = 0.1;
          //      val=(int)(price * Perc);
         //   }
            
           
            return val;
        }


    }
}
