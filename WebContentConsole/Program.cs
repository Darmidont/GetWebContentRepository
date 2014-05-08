using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using configuration = System.Configuration;

namespace WebContentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start program");
            Configuration.Configuration.ConfigureAutofac();
            
            Console.WriteLine("End a program");
            Console.ReadLine();
        }
    }
}
