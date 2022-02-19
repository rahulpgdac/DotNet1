using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class Employee
    {
        int IdNo;
        string Name;
        public void SetEmpData(int IdNo,string Name)
        {
            this.IdNo = IdNo;
            this.Name = Name;
            Console.WriteLine("Employee details saved");
        }
        public void DisplayEmpData()
        {
            Console.WriteLine($"Id:{IdNo}\tName:{Name}");

        }
        public override string ToString()
        {
            return $"Id:{IdNo}\tName:{Name}";
        }
    }
    class EmployeeMain
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); //Object Creation
            employee1.DisplayEmpData(); //0,null

            Employee employee2 = new Employee();  //Object Creation
            employee2.SetEmpData(1000,"Rahul");

            Console.WriteLine(employee2); //address
        }
    }
}
