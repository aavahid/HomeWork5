Person person = new Person("Reashad", "Pashayev", 12);
person.PrintPersonInfo();

Teacher teacher1 = new Teacher ("Nezrin", "Abdullayeva", 24);
teacher1.PrintPersonInfo();

Teacher teacher2 = new Teacher("Reashad", "Zekiyev", 44);
teacher2.PrintPersonInfo();

Teacher teacher3 = new Teacher("Suleyman", "Dadashov", 22);
teacher3.PrintPersonInfo();


Console.WriteLine($"student count: {Student.studentCount}");

Student student1 = new Student("Zahid", "Musayev", 18,teacher1);
student1.PrintPersonInfo();
student1.PrintTeacherName();

Console.WriteLine($"student count: {Student.studentCount}");

Student student2 = new Student("Ruslan", "Muradov", 19, teacher2);
student2.PrintPersonInfo();
student2.PrintTeacherName();

Console.WriteLine($"student count: {Student.studentCount}");

Student student3 = new Student("Vahid", "Aghazada", 29, teacher3);
student3.PrintPersonInfo();
student3.PrintTeacherName();

Console.WriteLine($"student count: {Student.studentCount}");

