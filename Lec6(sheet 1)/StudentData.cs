namespace StudentData;
using CourseData;

//** Create a Student class with Name and Courses.

public class Student
{
   public string Name { get; set; }
   public List<Course> Courses { get; set; }
   public Student(string name)
   {
      Name = name;
      Courses = new List<Course>();
   }
   public void AddCourse(string courseName, int grade)
   {
      Courses.Add(new Course(courseName, grade));
   }
}