using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgLang_Design_Principles
{
    

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

    abstract class ProgLang
    {
        protected Procedural p;
        protected ObjectOriented o;
        public abstract String getName();
        public String getUnit()
        {
            String str = "";
            if (p != null)
                str = p.getUnit();
            if (o != null)
                str += o.getUnit();
            return str;
        }

        public String getParadigm()
        {
            String str = "";
            if (p != null)
                str = p.getParadigm();
            if (o != null)
                str += o.getParadigm();
            return str;
        }

        
    }

    class LangC : ProgLang
    {
        public LangC()
        {
            p = new Procedural();
            o = null;
        }

        public override String getName()
        {
            return "C";
        }
    }

    class LangCobol : ProgLang
    {
        public LangCobol()
        {
            p = new Procedural();
            o = null;
        }

        public override String getName()
        {
            return "Cobol";
        }
    }

    class LangJava : ProgLang
    {
        public LangJava()
        {
            o = new ObjectOriented();
            p = null;
        }

        public override String getName()
        {
            return "Java";
        }
    }

    class LangCSharp : ProgLang
    {
        public LangCSharp()
        {
            o = new ObjectOriented();
            p = null;
        }

        public override String getName()
        {
            return "C#";
        }
    }

    class LangCPP : ProgLang
    {
        public LangCPP()
        {
            p = new Procedural();
            o = new ObjectOriented();
        }

        public override string getName()
        {
            return "CPP";
        }
    }

    class Design7
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
