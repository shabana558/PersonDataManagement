using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            PersonData.AddPersonDetailsIntoList(list);
            //PersonData.RetrievePersonAgeLessThan60(list);
            // PersonData.FindTeenageAgeRecords(list);
            // PersonData.FindAverageAge(list);
            // PersonData.SearchSpecificPersonBasedOnName(list,"Shabana");
            PersonData.RetrievePersonAgeGreaterThan60(list);
            Console.ReadLine();
        }
    }
}
