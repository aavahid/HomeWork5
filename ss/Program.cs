using System;

public class Person
{
    protected string name;
    protected string surname;
    protected int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public virtual void PrintPersonInfo()
    {
        Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}");
    }
}

public class Teacher : Person
{
    public Teacher(string name, string surname, int age)
        : base(name, surname, age)
    {
    }

    public override void PrintPersonInfo()
    {
        base.PrintPersonInfo();
        Console.WriteLine("Job: Teacher");
    }
}

public class Student : Person
{
    private Teacher teacher;
    public static int studentCount;

    public Student(string name, string surname, int age, Teacher teacher)
        : base(name, surname, age)
    {
        this.teacher = teacher;
        studentCount++;
    }

    public override void PrintPersonInfo()
    {
        base.PrintPersonInfo();
        Console.WriteLine("Job: Student");
    }

    public void PrintTeacherName()
    {
        Console.WriteLine($"{name}'s teacher name is: {teacher.Name}");
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person("Reashad", "Pashayev", 12);
        person.PrintPersonInfo();

        Teacher teacher1 = new Teacher("Nezrin", "Abdullayeva", 24);
        teacher1.PrintPersonInfo();

        Teacher teacher2 = new Teacher("Reashad", "Zekiyev", 44);
        teacher2.PrintPersonInfo();

        Teacher teacher3 = new Teacher("Suleyman", "Dadashov", 22);
        teacher3.PrintPersonInfo();

        Console.WriteLine($"Student count: {Student.studentCount}");

        Teacher[] teachers = { teacher1, teacher2, teacher3 };

        Student student1 = new Student("Zahid", "Musayev", 18, teacher1);
        student1.PrintPersonInfo();
        student1.PrintTeacherName();

        Console.WriteLine($"Student count: {Student.studentCount}");

        Student student2 = new Student("Ruslan", "Muradov", 19, teacher2);
        student2.PrintPersonInfo();
        student2.PrintTeacherName();

        Console.WriteLine($"Student count: {Student.studentCount}");

        Student student3 = new Student("Vahid", "Aghazada", 29, teacher3);
        student3.PrintPersonInfo();
        student3.PrintTeacherName();

        Console.WriteLine($"Student count: {Student.studentCount}");
    }
}
