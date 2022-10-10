using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class School
    {
        public string Name { get; set; }
        public int NumberofStudents { get; set; }

        public School()
        {

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} School has {NumberofStudents} students");
        }
    }
}
