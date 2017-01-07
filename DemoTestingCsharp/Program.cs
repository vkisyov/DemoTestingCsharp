using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestingCsharp
{
    class Program
    {
        // after execute exe argumets 
        static void Main(string[] args)
        {
             
            Console.WriteLine("Whats your name");
            // set string to 'name' and later read args 
            string name = Console.ReadLine();
            // numbers second method

            Console.WriteLine("hello, " + name);

            Console.WriteLine("how old are you?");
            int AgeOld = int.Parse(Console.ReadLine());


            if (AgeOld > 50)
            {

                Console.WriteLine("too old grandpa");
            }
            else
            {
                Console.WriteLine("its ok kiddo");
            }
        }
    }
}

       
