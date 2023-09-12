namespace ConsoleTutorial.OOPS
{
    public class Polymorphisam
    {
        public void MethodOverloadingDemo()
        {
            Console.WriteLine("Im in no p");
        }

        public void MethodOverloadingDemo(int a)
        {
            Console.WriteLine("{0}", a);
        }

        public void MethodOverloadingDemo(int b, int a)
        {
            Console.WriteLine($"{a},{b}");
        }

        public void MethodOverloadingDemo(string a)
        {
            Console.WriteLine("{0}", a);
        }



    }



    public class MyBase
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("From Base");
        }
    }

    public class MyDerived : MyBase
    {
        public override void MyMethod()
        {
            Console.WriteLine("From Base");
        }

    }
    public class MyDerived1 : MyDerived
    {
        public override void MyMethod()
        {
            Console.WriteLine("From Base");
        }

    }
}
