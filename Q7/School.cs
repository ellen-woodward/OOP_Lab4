using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class School : IComparable<School>
    {
        public string Name { get; set; }
        public int NumberofStudents { get; set; }

        public School() { }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} School has {NumberofStudents} students");
        }

        public int CompareTo(School that)
        {
            return this.NumberofStudents.CompareTo(that.NumberofStudents);
        }

        public void AddInfo()
        {
            Console.Write("\nEnter school name: ");
            Name = Console.ReadLine();

            Console.Write("\nEnter number of students: ");
            NumberofStudents = int.Parse(Console.ReadLine());
        }

    }
}
    
