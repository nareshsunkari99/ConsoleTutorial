namespace ConsoleTutorial.ClassObjectsDemo
{
    public class InstanceClass
    {
        int number1;
        int number2;

        ~InstanceClass() {  }

        public InstanceClass(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public int sum()
        {
            return number1 + number2;
        }
    }

    public static class StaticClass
    {

    }
}
