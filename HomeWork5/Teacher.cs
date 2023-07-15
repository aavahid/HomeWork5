using System;

public class Teacher : Person
{

    protected Teacher teacher;


    public Teacher(string name, string surname, int age ) : base(name, surname, age)
    {
         
    }

    public override void PrintPersonInfo()
    {
        Console.WriteLine($"name: {name}, surname: {surname}, age: {age}, job: Teacher");
    }

    public void PrintTeacherName()
    {

        Console.WriteLine($"{name}'s teacher name is: {TeacherName}");
    }

}
