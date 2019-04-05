using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Practice\Example.txt";

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person(entries[0], entries[1], entries[2]);

                people.Add(newPerson);
            }

            //Check to make sure foreach works as intended.
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Format}");
            }

            Console.ReadLine();
        }
    }
}
