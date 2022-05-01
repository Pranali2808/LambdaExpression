using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class PersonDataManagement
    {
        public static void GetRecords(List<Person> list)
        { Console.WriteLine("\n Records ");
            Program.DisplayPersonDetails(list);

        }
        public static void GetTop2RecordsBasedOnAge(List<Person> list)
        {
            Console.WriteLine("\n Get Top 2 Records Based on Age");
            List<Person> top2 = list.FindAll(p => p.Age < 60).OrderBy(a => a.Age).ToList();
            Program.DisplayPersonDetails(top2);
        }
        // Retrieve all record from the list age between 13 to 18
        public static void GetTenageRecords(List<Person> list)
        {
            Console.WriteLine("\n Get Tenage Records");
            List<Person> res = list.Where(p => p.Age >= 13 & p.Age <= 18).ToList();
            Program.DisplayPersonDetails(res);
        }
        //Retrieve average age in the list
        public static void FindAverage(List<Person> list)
        {
            Console.WriteLine("\n Average Age");
            double res = list.Average<Person>(a => a.Age);
            Console.WriteLine(res);

        }
        //Check for specific name present in the list or not
        public static void SearchPersonBasedOnName(string name, List<Person> list)
        {
            Console.WriteLine("\n Search Person By Name");
            List<Person> res = list.FindAll(p => p.Name == name);
            Program.DisplayPersonDetails(res);
        }
        //Skip record from the list for age is less than 60
        public static void SkipRecordAgeLessThan60( List<Person> list)
        {
            Console.WriteLine("\n Skip Record Less Than 60");
            List<Person> data = list.OrderBy(p => p.Age).SkipWhile(p => p.Age < 60).ToList();
            Program.DisplayPersonDetails(data);

        }
        public static void RemovePerson(string name, List<Person> list)
        {
            int res = list.RemoveAll(p => p.Name == name);
            Console.WriteLine();
            if (res != 0)
                Console.WriteLine("successfully removed all records");
            else
                Console.WriteLine("Failed to remove");
            Program.DisplayPersonDetails(list);
        }


    }
}
