using StudentData;

//*Q1: Create a Student class with Name and Courses. 
//*The Course class should have Course Name and Grade and method to add courses and grades.
//*Get the list of students who have a grade greater than 75 in all courses.
//*Calculate the average grade for each student. 
//*Find students who have more than 3 courses with an average grade above 80.
var students = new List<Student>
        {
            new Student("Abdullah Eweida"),
            new Student("Mohamed Moner"),
            new Student("Ahmed El-mohamedy"),
            new Student("Amr Waked")
        };
students[0].AddCourse("OOP", 90);
students[0].AddCourse("ODE", 85);
students[0].AddCourse("Math", 88);

students[1].AddCourse("Math", 80);
students[1].AddCourse("Physics", 76);
students[1].AddCourse("Linear Algebra", 70);
students[1].AddCourse("Geometric analysis", 82);
students[1].AddCourse("Mathimatical analysis 1", 85);

students[2].AddCourse("Mathimatical analysis 2", 95);
students[2].AddCourse("OOP", 92);
students[2].AddCourse("abstration algebra", 89);
students[2].AddCourse("Algebra", 91);

students[3].AddCourse("Atomic Physics", 74);
students[3].AddCourse("PDE", 84);
students[3].AddCourse("System Analysis", 74);

var studentsAbove75 = students.Where(s => s.Courses.All(c => (c.Grade > 75)));
Console.WriteLine("this students above  75% in all subjects");
foreach (var student in studentsAbove75)
{
   Console.WriteLine(student.Name);
}

Console.WriteLine("\nAverage students :");
foreach (var student in students)
{
   Console.WriteLine($"{student.Name}: {student.Courses.Average(c => c.Grade):F2}");
}

var studentsAbove80 = students.Where(s => s.Courses.Count(c => c.Grade >= 80) >= 3);
Console.WriteLine("\nStudents Above 80% in 3 subjects");
foreach (var student in studentsAbove80)
{
   Console.WriteLine(student.Name);
   foreach (var course in student.Courses)
      Console.WriteLine("--->Course : " + course.CourseName + " \t Grade :" + course.Grade);
}