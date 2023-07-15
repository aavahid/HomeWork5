using System;

public class Student : Person
{
    private Teacher teacher;
    public Teacher AssignedTeacher
    {
        get { return teacher; }
        set { teacher = value; }
    }

    public static int studentCount;
  

    static Student()
    {
        studentCount = 0;
    }
   
    public Student(string name, string surname, int age, Teacher teacher) : base(name, surname, age)
    {
        this.teacher = teacher;
        studentCount++;
    }

    public override void PrintPersonInfo()
    {
        Console.WriteLine($"name: {name}, surname: {surname}, age: {age}, job: Student");
    }
    public void PrintTeacherName()
    {

        Console.WriteLine($"{name}'s teacher name is: {teacher.TeacherName}");
    }

}
