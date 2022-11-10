using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset
{
     class Device
    {
        public Device(string type, string brand, string model, string office, DateTime purchaseDate, int price, string currency, int lokalPris)
        {
            Type = type;
            Brand = brand;
            Model = model;
            Office = office;
            PurchaseDate = purchaseDate;
            Price = price;
            Currency = currency;
            LokalPris = lokalPris;
        }

        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }
        public string Currency { get; set; }
        public int LokalPris { get; set; }

        public string Print()
        {

            return this.Type.PadRight(10)  + this.Brand.PadRight(10)  + this.Model.PadRight(10)  + this.Office.PadRight(10) 
                + this.PurchaseDate.ToString("yyyy-MM-dd").PadRight(20)  + this.Price.ToString().PadRight(15)  + this.Currency.PadRight(10)  + this.Price.ToString().PadRight(10);

        }
    }
}
