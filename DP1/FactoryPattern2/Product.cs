using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public enum PaymentMethod
    {
        BANK_ONE,
        BANK_TWO,
        BEST_FOR_ME,

        PAYPAL,
        BILL_DESK
    }
}
