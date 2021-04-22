using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Application
{
    class student
    {
        public int rollnumber { get; set; }
        public String name { get; set; }
        public String gender { get; set; }
        static void Main(string[] args)
        {
            student Student = new student();
            Student.rollnumber = 1;
            Student.name = "Adila MC";
            Student.gender = "Female";
            Console.WriteLine(Student.rollnumber + "\t" + Student.name + "\t" + Student.gender);
            Console.ReadLine();
        }
    }
}
