namespace CourseData;

/*should have Course Name and Grade 
and method to add courses and grades*/

public class Course
{
   public string CourseName { get; set; }
   public int Grade { get; set; }

   public Course(string courseName, int grade)
   {
      CourseName = courseName;
      Grade = grade;
   }
}