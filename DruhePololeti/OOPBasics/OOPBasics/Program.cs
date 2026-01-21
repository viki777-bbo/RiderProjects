





















Student student = new Student(16, "Viktor");
Console.WriteLine("Student name:" + student.name);
student.Greet();
ChangeStudent(student);
student.Greet();

void ChangeStudent(Student s)
{
    s.name = "Nothing";
}


