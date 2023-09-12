namespace ConsoleTutorial.OOPS
{
    public class InheritanceDemo
    {
        public void FromInheritanceDemo()
        {
            Console.WriteLine("I am from InheritanceDemo");
        }
    }

    public class SingleInheritance : InheritanceDemo
    {
        public void FromSingleInheritance()
        {
            Console.WriteLine("I am from SingleInheritance");
        }

        public new void FromInheritanceDemo()
        {
            Console.WriteLine("hi");
        }
    }

    public class MultiLevel : SingleInheritance
    {
        public void FromMultiLevelInheritance()
        {
            Console.WriteLine("I am from FromMultiLevelInheritance");
        }
    }

    //public class multiple : InheritanceDemo, SingleInheritance
    //{

    //}


    interface IRead
    {
        string Read();
    }

    interface Iwrite
    {
        void Write(string value);
    }

    public class DbOperations : IRead, Iwrite
    {
        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string value)
        {
            throw new NotImplementedException();
        }
    }

    public class FileOperations : InheritanceDemo, IRead, Iwrite
    {
        public string Read()
        {
            Console.WriteLine("Read");
            return "";
        }

        public void Write(string value)
        {
            Console.WriteLine(value);
        }
    }
}



