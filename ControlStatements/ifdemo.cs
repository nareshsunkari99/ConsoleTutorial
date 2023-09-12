namespace ConsoleTutorial.ControlStatements
{
    public class ifdemo
    {
        public static void SimpleIf(int a, int b)
        {
            if (a > b)
                Console.WriteLine("a is greater");
            else
                Console.WriteLine("b is greater");
            // (condition)?truecondition:falsecondition
            var demo = (a > b) ? "a is greater" : "b is greater";

            Console.WriteLine(demo);

            Console.WriteLine((a > b) ? "a is greater" : "b is greater");
        }


        public static void ladderIf(int a, int b, int c)
        {
            if(a>b && a>c)
            {
                Console.WriteLine("a is greater");
            }
            else if(b>c && b>a) {
                Console.WriteLine("b is greater");
            }
            else 
            {
                Console.WriteLine("c is greate");
            }

           // var x = (a > b && a > c) ? "a is greater" : (b > c && b > a) ? "b is greater" : "c is greate";
        }
    }
}
