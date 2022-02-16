using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class PersonData
    {
        public static void AddPersonDetailsIntoList(List<Person> list)
        {
            //object initializer
            //person p=newperson(){Address="bnglr",SSN=3,Age=23,Name="ABC"};
            list.Add(new Person() { SSN = 1, Age = 12, Address = "Hyderabad", Name = "Shabana" });
            list.Add(new Person() { SSN = 2, Age = 70, Address = "Chennai", Name = "Harika" });
            list.Add(new Person() { SSN = 3, Age = 32, Address = "Bangalore", Name = "Ambika" });
            list.Add(new Person() { SSN = 4, Age = 16, Address = "Kerala", Name = "Usha" });
            list.Add(new Person() { SSN = 5, Age = 63, Address = "kakinada", Name = "Mounika" });
            list.Add(new Person() { SSN = 6, Age = 36, Address = "Warangal", Name = "Ambika" });
            list.Add(new Person() { SSN = 1, Age = 14, Address = "Hyderabad", Name = "Kalpana" });
            IterateOverList(list);
        }
        public static void IterateOverList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }

        //uc5 Check for specific name present in the list or not
        public static void SearchSpecificPersonBasedOnName(List<Person> list, string name)
        {
            try
            {
                Person personRes = list.FindLast(Person => Person.Name == name);
                Console.WriteLine();
                if (personRes != null)
                {
                    Console.WriteLine(personRes);
                }
                else
                {
                    Console.WriteLine("Person not exist in the list");

                }
                Console.WriteLine();
                var per = list.FindAll(Person => Person.Name == name);
                IterateOverList(per);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


       

   

        

        

        
 

