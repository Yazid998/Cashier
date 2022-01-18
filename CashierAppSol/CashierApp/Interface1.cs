using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    interface IBaznaKlasa
    {
        string name { get; set; }
        int price { get; set; }
        string brend { get; set; }
        DateTime experationDate { get; set; }

    }
    interface IFoodKlasa
    {
        int Discount(int val);
        
    }
    interface IBeverageKlasa
    {
        int Discount_Bevearage(int val);
    }
    interface IClothesKlasa
    {
        string Size { get; set; }
        string Color { get; set; }
        int Discount_Clothes(int val);
    }
    interface IApplianceKlasa
    {
        DateTime ProductionDate { get; set; }
        int Weight { get; set; }
        string Model { get; set; }
    }
}
