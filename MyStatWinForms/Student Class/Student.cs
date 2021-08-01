using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStatWinForms
{
    public class Student
    {
        public int ID { get; set; }


        public string Name { get; set; }

        public string Surname { get; set; }

        public string FatherName { get; set; }

        public DateTime EntryTime { get; set; }

        public string getFullname() => $"{Name} {Surname} {FatherName}";



    }
}
