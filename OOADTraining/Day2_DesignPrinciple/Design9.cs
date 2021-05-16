using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgLang_Design_Principles
{

    interface Methodology
    {
        String getUnit();
        String getParadigm();
    }

    class ObjectOriented : Methodology
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

    class Procedural : Methodology
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

    class Heterogeneous : Methodology
    {
     
        public String getUnit()
        {
            return "FunctionClass";
        }

        public String getParadigm()
        {
            return "ProceduralObjectOriented";
        }

    }

    abstract class ProgLang
    {
        protected Methodology m1;

        public abstract String getName();

        public virtual String getUnit()
        {
            String str = "";
            if (m1 != null)
                str = m1.getUnit();
            return str;
        }

        public virtual String getParadigm()
        {
            String str = "";
            if (m1 != null)
                str = m1.getParadigm();
            return str;
        }


    }

    class LangC : ProgLang
    {
        public LangC()
        {
            m1 = new Procedural();
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
            m1 = new Procedural();
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
            m1 = new ObjectOriented();
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
            m1 = new ObjectOriented();
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
            m1 = new Heterogeneous();
        }

        public override String getName()
        {
            return "CPP";
        }
    }

    class Design9
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
