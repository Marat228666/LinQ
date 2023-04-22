using System.Security.Cryptography.X509Certificates;

List<Student> Students = new List<Student>
{
    new Student("Марат", 18, 1, false),
    new Student("Юля", 22, 3, false),
    new Student("Вадим", 25, 3, true),
    new Student("Наташа", 19, 2, false),
    new Student("Ваня", 18, 2, false),
    new Student("Саша", 20, 1, true),
    new Student("Женя", 23, 2, false),
    new Student("Гена", 21, 1, false),
    new Student("Тихон", 28, 3, false),
    new Student("Аня",18, 2, true),
    
};
var NameList = Students.ToList().OrderBy(s => s.Name);
Console.WriteLine("\nSorted by name");
NameList.ToList().ForEach(s => Console.WriteLine(s));
var AgeList = Students.ToList().OrderBy(s => s.Age);
Console.WriteLine("\nSorted by Age");
AgeList.ToList().ForEach(s => Console.WriteLine(s));
var CourseList = Students.ToList().OrderBy(s => s.CourseNumber);
Console.WriteLine("\nSorted by Course Number");
CourseList.ToList().ForEach(s => Console.WriteLine(s));
var ExpelledList = Students.ToList().OrderBy(s => s.Expelled);
Console.WriteLine("\nSorted by expelled");
ExpelledList.ToList().ForEach(s => Console.WriteLine(s));

var stcourse=Students.ToList().Where(s=>s.CourseNumber==1);
Console.WriteLine("\n1st course");
stcourse.ToList().ForEach(s=> Console.WriteLine(s));
var ndcourse=Students.ToList().Where(s=>s.CourseNumber==2);
Console.WriteLine("\n2nd course");
ndcourse.ToList().ForEach(s=> Console.WriteLine(s));
var rdcourse=Students.ToList().Where(s=>s.CourseNumber==3);
Console.WriteLine("\n3rd course");
rdcourse.ToList().ForEach(s=> Console.WriteLine(s));

var CourseAndNameList = Students.ToList().Where(s=>s.Expelled==false).OrderBy(s => s.CourseNumber).ThenBy(s => s.Name);
Console.WriteLine("\nSorted by Course And Name");
CourseAndNameList.ToList().ForEach(s => Console.WriteLine(s));

class Student
{ 
    public string Name { get; set; }
    public int Age { get; set; }
    public int CourseNumber { get; set; }
    public bool Expelled { get; set; }

    public Student(string name, int age, int courseNumber, bool expelled)
    {
        Name = name;    
        Age = age;
        CourseNumber = courseNumber;
        Expelled= expelled;
        
        
    }
    public override string ToString()
    {
        return $"Name:{Name}, Age:{Age}, Course:{CourseNumber}, EXpelled:{Expelled}";
    }
}