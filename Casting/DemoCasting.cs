namespace ConsoleTutorial.Casting
{
    public class DemoCasting
    {
        public long ImplicitCasting(int input)
        {
            //Console.WriteLine($"Int Min : {int.MinValue} Max: {int.MaxValue}");
            //Console.WriteLine($"long Min : {long.MinValue} Max: {long.MaxValue}");
            //Console.WriteLine($"long Min : {short.MinValue} Max: {short.MaxValue}");
            //long result = input;
            return input ;
        }

        public int ExplicitCasting(long input)
        {

            return (int)input;
        }
    }
}