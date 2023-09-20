using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTutorial.ExceptionHandling
{
    public class ExceptionHandlingDemo
    {
        public int Division(int a, int b)
        {
            try
            {
                return a / b;
            }
            
            catch(DivideByZeroException  ex) { 
            Console.WriteLine(ex.Message);
                return -1;
            }
           
            finally
            {
                Console.WriteLine("from finally");
            }
        }
    }
}
