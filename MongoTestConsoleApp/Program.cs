using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Norm;

namespace MongoTestConsoleApp
{
    public class Employee
    {
        [MongoIdentifier]
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "emp1";

            IMongo db = Mongo.Create("mongodb://localhost/MongoTest");

            db.GetCollection<Employee>().Save(emp);
        }
    }
}
