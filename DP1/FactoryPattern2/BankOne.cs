using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class BankOne : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            // The bank specific API call to make the payment
            Console.WriteLine("Using bank1 to pay for {0}, amount {1}", product.Name, product.Price);
        }
    }
}
