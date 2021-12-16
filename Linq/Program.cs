using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons();
            var numbersArray = Enumerable.Range(1, 10).ToArray();
            var numbersList = Enumerable.Range(1, 10).ToList();

            var str = "Hej";

            var hejDå = str.Add("Då");
            var manyWords = str.Add("Då", "Vi", "Ses", "Imorgon");

           // Console.WriteLine(hejDå);
           // Console.WriteLine(manyWords);

            var longnames = persons.ReturnIfTrue(p => p.Name.Length > 10 && p.Age < 40);
            var shortnames = persons.Where(p => p.Name.Length < 10);
            var youngPeople = persons.Where(Test);

            //foreach (var item in youngPeople)
            //{
            //    Console.WriteLine(item);
            //

            //foreach (var item in longnames)
            //{
            //    Console.WriteLine(item);
            //}

            var numbersInRange = numbersList.ReturnIfTrue(n => n <= 5).Sum();

            //foreach (var item in numbersInRange)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine(numbersInRange);

            var result = persons.Where(p => p.Name.StartsWith("S"))
                                .Where(p => p.Name.EndsWith("a"))
                                .Select(p => new PersonDto()
                                {
                                    Name = p.Name,
                                    NamesLength = p.Name.Length
                                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.NamesLength}");
            }
            

        }

        private static bool Test(Person person)
        {
            return person.Age < 40;
        }

        private static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 32),
            };
        }
    }
}
