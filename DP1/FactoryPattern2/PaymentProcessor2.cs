using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class PaymentProcessor2
    {
        IPaymentGateway gateway = null;

        public void MakePayment(PaymentMethod method, Product product)
        {
            PaymentGatewayFactory2 factory = new PaymentGatewayFactory2();
            this.gateway = factory.CreatePaymentGateway(method, product);

            this.gateway.MakePayment(product);
        }
    }
}
