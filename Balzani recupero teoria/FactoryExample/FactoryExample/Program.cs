using FactoryExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson person = AgeSelector.Select(5);
            
            Console.WriteLine(person.ShowPerson());
            Console.ReadKey();
        }
    }
}
