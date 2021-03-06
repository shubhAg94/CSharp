using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgLang_Design_Principles
{
    interface ProgLang
    {
        String getUnit();
        String getParadigm();
        String getName();
    }

    abstract class ObjectOriented : ProgLang
    {
        public String getUnit()
        {
            return "Class";
        }
        public String getParadigm()
        {
            return "ObjectOriented";
        }
        public abstract String getName();
    }

    abstract class Procedural : ProgLang
    {
        public String getUnit()
        {
            return "Function";
        }
        public String getParadigm()
        {
            return "Procedural";
        }
        public abstract String getName();
    }

    class LangC : Procedural
    {
        public override String getName()
        {
            return "C";
        }
    }

    class LangCSharp : ObjectOriented
    {
        public override String getName()
        {
            return "C#";
        }
    }
    class LangJava : ObjectOriented
    {
        public override String getName()
        {
            return "Java";
        }
    }


    class Design1
    {
        static void Main(string[] args)
        {
            int choice;
            ProgLang p = null;

            do
            {
                Console.WriteLine("1:LangC \n2:LangJava \n3:LangCSharp \nEnter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        p = new LangC();
                        break;

                    case 2:
                        p = new LangJava();
                        break;

                    case 3:
                        p = new LangCSharp();
                        break;
                }
                Console.WriteLine("Unit:" + p.getUnit());
                Console.WriteLine("Paradigm:" + p.getParadigm());
                Console.WriteLine("Name:" + p.getName());
                Console.WriteLine("Enter 1 to continue");
                choice = int.Parse(Console.ReadLine());
            } while (choice == 1);
        }
    }
}
