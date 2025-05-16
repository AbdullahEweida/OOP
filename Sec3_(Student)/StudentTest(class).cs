namespace Student;

public class StudentTest
{
    private static List<GetStudent> Students = new List<GetStudent> ();
    public static List<GetStudent> students
    {
        get { return Students; }
    }
    public static void CreateStudents()
    {
        GetStudent student = new GetStudent("3abdullah Eweida", "Software engneer", "OOP", "Menofiya university","ABE@mail", 20);
        GetStudent student1 = new GetStudent("3amar 3emad", "Software Engneer", "OOP");
        GetStudent student2 = new GetStudent("Mohamed Tayel", "Web devolepment", "HTML", "Menofiya university", "Tayel@mail", 25);
        GetStudent student3 = new GetStudent("Mohamed Hany", "Cyber security", "Python");
        Students.Add(student);
        Students.Add(student1);
        Students.Add(student2);
        Students.Add(student3);
    }
}
