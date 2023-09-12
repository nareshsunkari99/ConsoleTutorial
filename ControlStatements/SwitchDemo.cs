namespace ConsoleTutorial.ControlStatements
{
    public class SwitchDemo
    {
        public static void SwitchEx(int input)
        {
            switch (input)
            {
                case 20:
                    Console.WriteLine("you are at 20");
                    break;
                case 30:
                    Console.WriteLine("you are at 30");
                    break;
                case 40:
                    Console.WriteLine("you are at 40");
                    break;
                case 50:
                    Console.WriteLine("you are at 50");
                    break;
                default:
                    Console.WriteLine("you doesnt belong to here");
                    break;

            }

            var result =
                 input switch { 
                     20 => "at 20",
                     30 => "at 30",
                     40 => "at 40",
                     50 => "at 50",
                     _ => "not valid"
                 };

            Console.WriteLine(result);
        }
    }
}
