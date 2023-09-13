using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTutorial.OOPS
{
    
    public abstract class AbstractionDemo
    {
       public  abstract void Details();

        public virtual  void Implemented()
        {
            Console.WriteLine("Hi");
        }
    }

    public class Implementor : AbstractionDemo
    {
        public override void Details()
        {
            Console.WriteLine("Hi from implementation");
        }

        public override void Implemented()
        {
            Console.WriteLine("Hi from implementation");
        }

    }
}
