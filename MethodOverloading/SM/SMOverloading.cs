namespace SM
{
    class SMOverloading
    {
        public static int M1(int a)
        {
            return a;
        }

        public static double M1(double a)
        {
            return a;
        }
    }

    class SM2
    {
        public static int M1(int a, double d)
        {
            return a;
        }

        public static double M1(double d, int a)
        {
            return a;
        }
    }

    class SM3
    {
        public static int M1(int a, double d = 3)
        {
            return a;
        }

        public static int M1(int a)
        {
            return a;
        }
    }

    class SM4
    {
        public static int M1(int a, double d = 3)
        {
            return a;
        }

        //Not Possible return type is not part of method signature
        //public static double M1(int a, double d)
        //{
        //    return a;
        //}
    }

    class SM5
    {
        public static void M1(int a, int b = 3, int c = 5)
        {
            System.Console.WriteLine("M1 with two optional parameter");
        }

        public static void M1(int a, int b = 3)
        {
            System.Console.WriteLine("M1 with one optional parameter");
        }
    }

    class SM6
    {
        public static void M1(int a = 2, int b = 3, int c = 5)
        {
            System.Console.WriteLine("M1 with three optional parameter");
        }

        public static void M1(int a = 1, int b = 3)
        {
            System.Console.WriteLine("M1 with two optional parameter");
        }
    }
}
