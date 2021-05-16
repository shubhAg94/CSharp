using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHashMap
{
    public class City
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            City c1 = new City();
            City c2 = new City();
            City c3 = new City();
            Object o = new object();
            Dictionary<City, string> d = new Dictionary<City, string>();
            d.Add(c1, "Jaipur");
            d.Add(c2, "Delhi");
            Console.Write(d[c3]);

            Console.ReadLine();
        }
    }
}
