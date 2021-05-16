namespace FactoryPattern2
{
    public class PaymentProcessor
    {
        IPaymentGateway gateway = null;

        public void MakePayment(PaymentMethod method, Product product)
        {
            //Now our client class does not depend on the concrete payment gateway classes. 
            //It also does not have to worry about the creation logic of the concrete payment gateway classes. 
            //All this is nicely abstracted out in the factory class itself.
            PaymentGatewayFactory factory = new PaymentGatewayFactory();
            gateway = factory.CreatePaymentGateway(method, product);

            gateway.MakePayment(product);
        }
        //The Factory pattern is a very useful pattern when it comes to keeping our client code decoupled from dependent classes. 
        //It enables the application to be maintained more easily. It also makes it very easy to extend as new concrete classes 
        //can be added as without impacting the existing concrete classes and the client code.
    }
}
