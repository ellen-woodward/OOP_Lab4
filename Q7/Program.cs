using Q7;

List <School> schools = new List<School>();

for (int i = 0; i < 5; i++)
{
    School school = new School();
    school.AddInfo();
    schools.Add(school);
}

schools.Sort();

foreach (School school in schools)
{
    school.DisplayInfo();
}

Console.ReadLine();