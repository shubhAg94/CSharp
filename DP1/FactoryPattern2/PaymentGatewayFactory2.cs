namespace FactoryPattern2
{
    public class PaymentGatewayFactory2 : PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(PaymentMethod method, Product product)
        {
            IPaymentGateway gateway = null;

            switch (method)
            {
                case PaymentMethod.PAYPAL:
                    // gateway = new PayPal();
                    break;
                case PaymentMethod.BILL_DESK:
                    // gateway = new BillDesk();
                    break;
                default:
                    gateway = base.CreatePaymentGateway(method, product);
                    break;
            }

            return gateway;
        }
    }
}
