using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddPersonDetails(list);
            PersonDataManagement.GetRecords(list);
            //PersonDataManagement.GetTop2RecordsBasedOnAge(list);
            // PersonDataManagement.GetTenageRecords(list);
            //PersonDataManagement.FindAverage(list);
            //PersonDataManagement.SearchPersonBasedOnName("Karan",list);
             //PersonDataManagement.SkipRecordAgeLessThan60(list);
            PersonDataManagement.RemovePerson( "Karan",list);
            Console.ReadLine();
        }
        public static void AddPersonDetails(List<Person>list)
        {
            list.Add(new Person() { SSN = 1, Name = "Kavya", Address = "Pune", Age = 12 });
            list.Add(new Person() { SSN = 2, Name = "Ram", Address = "Mumbai", Age = 70 });
            list.Add(new Person() { SSN = 3, Name = "Sam", Address = "Beed", Age = 32 });
            list.Add(new Person() { SSN = 4, Name = "Karan", Address = "Bhusawal", Age = 18 });
            list.Add(new Person() { SSN = 5, Name = "Kajal", Address = "Nashik", Age = 63 });
            list.Add(new Person() { SSN = 6, Name = "Kavita", Address = "Raipur", Age = 36 });
            list.Add(new Person() { SSN = 6, Name = "Kiara", Address = "Badoda", Age = 14 });

        }
        public static void DisplayPersonDetails(List<Person> list)
        {
            foreach(Person person in list)
            {
                Console.WriteLine(person);
            }
            
        }
    }
}
