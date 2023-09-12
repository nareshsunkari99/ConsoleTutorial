namespace ConsoleTutorial.MethodsDemo
{
    public  class FunctionsDemo
    {
        public void PrintHello()
        {
            Console.WriteLine("Hell0");
        }

        public int Sum(int a,int b)
        {
            return a + b;
        }
        public  (int,int,string) SumSub(int a, int b)
        {
            return (a + b,a-b,"Hello");
        }

        public void DemoOut(out int result,int a,int b, out string myData)
        {
            result = a + b;
            myData = "Hello";
        }

        public void Demo(ref int a)
        {
            a++; // a=a+1;
        }
       
    }
}
