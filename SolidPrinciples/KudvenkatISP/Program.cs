using System;

namespace KudvenkatISP
{
    /*
     The interface-segregation principle (ISP) states that "no client should be forced to depend on methods it does not use".

     This means, instead of one fat interface many small interfaces are preferred based on groups of methods with each one 
     serving one sub-module. So Client should only know about the interfaces or method that are revelent to them 

     The ISP was first used and formulated by Robert C. Martin while consulting for Xerox. 

     Instead of one fat interface many small interfaces are preferred based on groups of methods with 
     each one serving one sub-module.

     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Simple Example of ISP
    //Voilating ISP and SRP also
    interface IUser
    {
        bool Login(string name, string password);
        bool Register(string name, string password, string email);
        void LogError(string error);
        bool SendMail(string emailContent);
    }


    //Following ISP
    interface IUser1
    {
        bool Login(string name, string password);
        bool Register(string name, string password, string email);
    } 

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendMail(string emailContent);
    }
}
