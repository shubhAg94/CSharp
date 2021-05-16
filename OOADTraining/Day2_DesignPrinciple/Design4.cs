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

    class LangCobol : Procedural
    {
        public override String getName()
        {
            return "Cobol";
        }
    }

    class ProcImpl : Procedural
    {
        public override String getName()
        {
            return "";
        }
    }

    class OOImpl : ObjectOriented
    {
        public override String getName()
        {
            return "";
        }
    }

    abstract class Heterogeneous : ProgLang
    {
        protected ObjectOriented o;
        protected Procedural p;

        public Heterogeneous()
        {
            p = new ProcImpl();
            o = new OOImpl();
        }

        public String getUnit()
        {
            return p.getUnit() + p.getParadigm();
        }

        public String getParadigm()
        {
            return p.getParadigm() + o.getParadigm();
        }
        abstract public String getName();
    }

    class LangCPP : Heterogeneous
    {
        public override string getName()
        {
            return "CPP";
        }
    }

    class Design4
    {
        static void Main(string[] args)
        {
            int choice;
            ProgLang p = null;

            do
            {
                Console.WriteLine("1:LangC \n2:LangJava \n3:LangCSharp \n4:LangCobol \n5:LangCPP \nEnter your choice");
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

                    case 4:
                        p = new LangCobol();
                        break;

                    case 5:
                        p = new LangCPP();
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
