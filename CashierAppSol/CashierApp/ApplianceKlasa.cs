using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class ApplianceKlasa:BaznaKlasa,IApplianceKlasa
    {
        private DateTime _ProductionDate;
        private int _Weight;
        private string _Model;

        public DateTime ProductionDate
        {
            get { return _ProductionDate; }
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
        public int Weight
        {
            get { return _Weight; }
            set {
                if (value > 0)
                {
                    _Weight = value;
                }
                else
                {
                    throw new Exception("Vrednost mora da bude veca od 0!");
                }

                }
            
        }
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
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
                    throw new Exception("Cena mora biti veca!");
                }
            }


        }
        public new string brend
        {
            get { return _brend; }
            set { _brend = value; }
        }

      
    }
}
