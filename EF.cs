using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    // ADO.NET Entity DATA Model -- as EnitityModel
    class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                Console.WriteLine("Print all: ");
                entities.Employees.ToList().ForEach(r => Console.WriteLine(JsonConvert.SerializeObject(r)));
            }
        }
    }
}
