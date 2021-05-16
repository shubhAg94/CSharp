namespace SM
{
    class Base2
    {
        public virtual void M1(int a)
        {
            System.Console.WriteLine($"Base2 {a}");
        }
    }
    class Child2 : Base2
    {
        public override void M1(int a)
        {
            System.Console.WriteLine($"Child2 {a}");
        }

        //Not Possible
        //public  int M1(int d)
        //{
        //    return d;
        //}
    }
    class Child3: Child2
    {
        public new void M1(int a)
        {
            System.Console.WriteLine($"Child3 {a}");
        }
    }
}
