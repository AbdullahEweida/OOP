//We are given a school.
//The school has classes of students.
//Each class has a set of teachers.
//Each teacher teaches a set of courses.
//The students have a name and unique number in the class.
//Classes have a unique text identifier.
//Teachers have names.
//Courses have a name, count of classes and count of exercises. 
//The teachers as well as the students are people. 
//Your task is to model the classes (in terms of OOP) along with their attributes and operations define the class hierarchy and create a classes.
using SchoolSys;

var school = new School();

var classA = new ClassRoom("Class A");
var student1 = new Student("Ali", 1);
var teacher1 = new Teacher("Ms. Sara");

var math = new Course("Mathematics", 20, 10);
teacher1.AddCourse(math);

classA.AddStudent(student1);
classA.AddTeacher(teacher1);

school.AddClass(classA);

Console.WriteLine($"School has {school.Classes.Count} class(es).");