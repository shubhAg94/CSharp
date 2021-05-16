using System;

namespace FactoryPattern2
{
    public class BankTwo : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            // The bank specific API call to make the payment
            Console.WriteLine("Using bank2 to pay for {0}, amount {1}", product.Name, product.Price);
        }
    }
}
