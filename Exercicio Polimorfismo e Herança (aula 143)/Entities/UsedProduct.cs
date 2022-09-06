using System;
using System.Globalization; 

namespace Exercicio_Polimorfismo_e_Herança__aula_143_.Entities
{
    class UsedProduct:Product
    {
        public DateTime ManuFactureDate { get; set; }
        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manuFactureDate):base(name,price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price + " (Manufacture date: " + ManuFactureDate.ToString("dd/MM/yyyy") + ")";
        }


    }
}
