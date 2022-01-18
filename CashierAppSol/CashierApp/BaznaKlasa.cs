using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class BaznaKlasa:IBaznaKlasa
    {
        public string _name;
        public int _price;
        public string _brend;
        public DateTime _experation_date;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string brend
        {
            get { return _brend; }
            set { _brend = value; }
        }
        public DateTime experationDate
        {
            get { return _experation_date; }
            set { _experation_date = value;}
        }

    }
}
