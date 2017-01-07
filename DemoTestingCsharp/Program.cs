using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestingCsharp
{
    class Program
    {
        // argumets
        static void Main(string[] args)
        {
            
            Console.WriteLine("ТИ КОЙ СИ ? (Напиши си името)");
            // set string to 'name' and later read args 
            string name = Console.ReadLine();
            // print string name 
            Console.WriteLine("Здравей, " + name);
            Console.WriteLine("ти спечели борбата с конзолката");
        }
    }
}

