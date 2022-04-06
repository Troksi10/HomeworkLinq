
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLinq
{
	class Program
	{

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
            new Person("Bill", "Smith", 41, 'M'),
            new Person("Sarah", "Jones", 22, 'F'),
            new Person("Stacy","Baker", 21, 'F'),
            new Person("Vivianne","Dexter", 19, 'F' ),
            new Person("Bob","Smith", 49, 'M' ),
            new Person("Brett","Baker", 51, 'M' ),
            new Person("Mark","Parker", 19, 'M'),
            new Person("Alice","Thompson", 18, 'F'),
            new Person("Evelyn","Thompson", 58, 'F' ),
            new Person("Mort","Martin", 58, 'M'),
            new Person("Eugene","deLauter", 84, 'M' ),
            new Person("Gail","Dawson", 19, 'F' ),
            };

            // Task 01
            // all people aged 50 or more

            List<Person> peopleaged50OrMore = people
                                                    .Where(x => x.Age >= 50)
                                                    .ToList();
            peopleaged50OrMore.ForEach(x => Console.WriteLine(x.FirstName));

            // Task 02
            // all people name starts with B

            List<Person> nameStartsWithB = people
                                                 .Where(x => x.FirstName.StartsWith("S"))
                                                 .ToList();
            nameStartsWithB.ForEach(x => Console.WriteLine(x.FirstName));


            // Task 03
            // first person whose surname starts with T

            List<Person> surnameStartsWithT = people
                                                    .Where(x => x.LastName.StartsWith("T"))
                                                    .ToList();
            surnameStartsWithT.ForEach(x => Console.WriteLine(x.LastName));

            // Task 04
            // find youngest and oldest person

            int youngestStudent = people
                                         .Select(x => x.Age)
                                         .Min();
            int oldestStudent = people
                                      .Select(x => x.Age)
                                      .Max();

            Console.WriteLine("Age of youngest student is {0} and of oldest is {1}", youngestStudent, oldestStudent);


            // Task 05
            // find all male people aged 45 or more

            List<Person> genderMaleover45 = people
                                                 .Where(x => x.Gender == 'M')
                                                 .Where(x => x.Age > 45)
                                                 .ToList();

            genderMaleover45.ForEach(x => Console.WriteLine(x.FirstName));


            // Task 06
            // find all females whose name starts with V

            List<Person> femaleWithV = people
                                            .Where(x => x.Gender == 'F')
                                            .Where(x => x.FirstName.StartsWith("V"))
                                            .ToList();

            femaleWithV.ForEach(x => Console.WriteLine(x.FirstName));

            // Task 07
            // find last female person older than 30 whose name starts with p

            Person lastFemaleOlderThan30NameWithP = people
                                                         .Where(x => x.Gender == 'F')
                                                         .Where(x => x.FirstName.StartsWith("P"))
                                                         .Where(x => x.Age > 30)
                                                         .LastOrDefault();

            Console.WriteLine(lastFemaleOlderThan30NameWithP.Name);

            // Task 08
            // find first male younger than 40

            Person firstMaleYoungerthan40 =people
                                                 .FirstOrDefault(x => x.Gender == 'M' && x.Age < 40);

            Console.WriteLine(firstMaleYoungerthan40.Name);

            // Task 09
            // print the names of the male persons that have firstName longer than lastName

            List<Person> NamesOfTheMalePersons = people
                                                       .Where(x => x.Gender == 'M')
                                                       .Where(x => x.FirstName.Length > x.LastName.Length)
                                                       .ToList();

            NamesOfTheMalePersons.ForEach(x => Console.WriteLine(x.FirstName));


            // Task 10
            // print the lastNames of the female persons that have odd number of ages

            List<Person> LastNamesFemalePersonsOdd = people
                                                          .Where(x => x.Gender == 'F')
                                                          .Where(x => x.LastName.Length % 2 == 0)
                                                          .ToList();

            LastNamesFemalePersonsOdd.ForEach(x => Console.WriteLine(x.LastName));

            Console.ReadLine();
        }
    }
}
