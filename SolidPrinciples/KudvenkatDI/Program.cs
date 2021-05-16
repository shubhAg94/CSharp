using System;

namespace KudvenkatDI
{
    /*
    High-level modules should not depend on low-level modules. Both should depend on abstractions.
    Abstractions should not depend on details. Details should depend on abstractions.
     
    To simplify this we can state that while designing, the interaction between a high-level module and a low-level one, 
    the interaction should be thought of as an abstract interaction between them. 

    During the process of the application design, lower-level components are designed to be consumed by higher-level 
    components which enable increasingly complex systems to be built. In this Process of Composition, higher-level components 
    depend directly upon lower-level components to achieve some task. 

    This dependency upon lower-level components limits the reuse opportunities of the higher-level components and 
    ends up in a bad design.

    Now let’s take a look at button click event example from the Presentation layer that calls directly the Employee 
    Save Method of Business logic which does some validation checks before saving the employee details to DB. 

    This flow looks absolutely fine however we are coupling different layers and as said earlier, 
    any further changes are complicated and cumbersome.

     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /* For Example:
    public class BusinessLogicLayer
    {
        private readonly DataAccessLayer DAL;

        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public class DataAccessLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
    Notice from the above code the BLL is directly dependent on the low level Data Access Layer and it’s hard to perform 
    any unit tests on this code as both are coupled. Of course, we can do some amount of testing on the DAL but imagine 
    if the DAL needs to be further extended to SQL and XML layers. If we need to that, implementation to extend it, 
    becomes tedious and much more complicated. 
    In order to achieve that we introduce interface that acts as abstraction so that both are decoupled.

    Hence based on the DIP we apply an Abstraction to decouple these layers.

    If you take a look at this code based on the pictorial representation diagram we have introduced the Interface which is 
    extended by the Data Access Layer and referred in the BLL. Hence we can say that Irepository layer acts as abstraction 
    between these modules.
    
    public class BusinessLogicLayer
    {
        private readonly IRepositoryLayer DAL;

        public BusinessLogicLayer(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayer : IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
    Adapter Design pattern can be seen as an example which is applying the dependency inversion principle.
    The high-level class defines its own adapter interface which is the abstraction that the other high-level classes depend on. 
    The Adaptee implementation also depends on the adapter interface abstraction.
     */
}
