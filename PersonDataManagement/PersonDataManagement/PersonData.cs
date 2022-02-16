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
       
        //uc7 Remove Specific Name from the list
        public static void RemovePerson(List<Person> list,string name)
        {
            int res=list.RemoveAll(p=>p.Name == name);
            Console.WriteLine();
            //var topTwoRecords=sortedResults.Take(2).ToList();
            Console.WriteLine("remove operation");
            if (res != 0)
                Console.WriteLine("successfully removed all records");
            else
                Console.WriteLine("failed to remove");
            IterateOverList(list);
            
        }
    }
}
                
        

    



       

   

        

        

        
 

