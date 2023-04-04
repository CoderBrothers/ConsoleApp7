using ConsoleApp7;

Crisps crisps = new Crisps();
crisps.Buy();
crisps.About();
Crisps crisps1 = new Crisps("Pringles",250,50,"Мёд");
crisps1.Buy();
crisps1.About();
Console.WriteLine(Crisps.Counter);
Crisps.GetCount();
Console.WriteLine(crisps.Id);
Console.WriteLine(crisps1.Id);
Student student = new Student();
student.SeyHello();
student.Dokumenty();
student.NumberOfStudents();
Student student1 = new Student("Tom", 70, 0953600307, "Вінниця", "Швеція", "School №17", "Group number 2");
student1.SeyHello();
student1.Dokumenty();
student1.NumberOfStudents();
Console.WriteLine(Student.CounterStudent);
Console.WriteLine(student.IdStudent);
Console.WriteLine(student1.IdStudent);


