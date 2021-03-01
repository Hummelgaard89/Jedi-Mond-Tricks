using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Mond_Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg. 1 Declaring a dictionary.
            Dictionary<string, int> persons = new Dictionary<string, int>();
            //Opg. 2 Adding people.
            persons.Add("Casper", 32);
            persons["Hummelgaard"] = 23;
            Console.WriteLine( persons.First() );
            //Adding Han to be removed later on.
            persons.Add("Han", 54);//Notice his age! Little Easteregg.
            Console.WriteLine();
            //Just to show he's in there.
            foreach (KeyValuePair<string, int> person in persons)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            //Removing Han.
            persons.Remove("Han");
            //Han solo(ng)
            foreach (KeyValuePair<string, int> var in persons)
            {
                Console.WriteLine(var);
            }
            Console.ReadLine();
        }
    }
}
