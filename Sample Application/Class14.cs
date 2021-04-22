using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class Class14
    {
        public struct Employee
        {
            public int EmployeeId;
            public string EmployeeName;
        }
        static void Main(string[] args)
        {
            Employee employee;
            employee.EmployeeId = 101;
            employee.EmployeeName = "Adila MC";
            Console.WriteLine(employee.EmployeeId + "\t" + employee.EmployeeName);
            Console.ReadLine();
        }
    }
}
