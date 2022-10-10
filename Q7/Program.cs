using Q7;

School school1 = new School();
AddInfo(school1);

School school2 = new School();
AddInfo(school2);

School school3 = new School();
AddInfo(school3);

School school4 = new School();
AddInfo(school4);

School school5 = new School();
AddInfo(school5);


static void AddInfo(School school)
{
    Console.Write("\nEnter school name: ");
    school.Name = Console.ReadLine();

    Console.Write("\nEnter number of students: ");
    school.NumberofStudents = int.Parse(Console.ReadLine());
}