namespace ConsoleTutorial.Variables
{
    public class DemoOnVariables
    {
        public static decimal ReadDemcimalInput()
        {
            Console.WriteLine("Enter a decimal Value");
            return Convert.ToDecimal(Console.ReadLine());
        }
    }
}