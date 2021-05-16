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

    class ObjectOriented
    {
        public String getUnit()
        {
            return "Class";
        }
        public String getParadigm()
        {
            return "ObjectOriented";
        }
        
    }

    class Procedural 
    {
        public String getUnit()
        {
            return "Function";
        }
        public String getParadigm()
        {
            return "Procedural";
        }
    }

    class LangC : ProgLang
    {
        Procedural p;
        
        public LangC()
        {
            p = new Procedural();
        }

        public String getUnit()
        {
            return p.getUnit();
        }

        public String getParadigm()
        {
            return p.getParadigm();
        }

        public String getName()
        {
            return "C";
        }
    }

    class LangCobol : ProgLang
    {
        Procedural p;

        public LangCobol()
        {
            p = new Procedural();
        }

        public String getUnit()
        {
            return p.getUnit();
        }

        public String getParadigm()
        {
            return p.getParadigm();
        }

        public  String getName()
        {
            return "Cobol";
        }
    }

    class LangJava : ProgLang
    {
        ObjectOriented o;

        public LangJava()
        {
            o = new ObjectOriented();
        }

        public String getUnit()
        {
            return o.getUnit();
        }

        public String getParadigm()
        {
            return o.getParadigm();
        }

        public String getName()
        {
            return "Java";
        }
    }

    class LangCSharp : ProgLang
    {
        ObjectOriented o;

        public LangCSharp()
        {
            o = new ObjectOriented();
        }

        public String getUnit()
        {
            return o.getUnit();
        }

        public String getParadigm()
        {
            return o.getParadigm();
        }

        public String getName()
        {
            return "C#";
        }
    }

    abstract class Heterogeneous : ProgLang
    {
        protected ObjectOriented o;
        protected Procedural p;

        public Heterogeneous()
        {
            p = new Procedural();
            o = new ObjectOriented();
        }

        public String getUnit()
        {
            return p.getUnit() + o.getUnit();
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

    class Design6
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
