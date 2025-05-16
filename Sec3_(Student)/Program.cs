using Student;

StudentTest.CreateStudents();
foreach(var student in StudentTest.students)
{
    Console.WriteLine("======================================");
    student.DisplayInfo();
    Console.WriteLine("======================================");
}