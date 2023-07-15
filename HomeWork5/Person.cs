using System;

public class Person
{
    protected string name;
    protected string surname;
    protected int age;
    
    public string TeacherName
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
        }
    }
   
    public Person(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        
    }
    public virtual void PrintPersonInfo()
    {
        Console.WriteLine($"name: {name}, surname: {surname}, age: {age}");

    }   
}

