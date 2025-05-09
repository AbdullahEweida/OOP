namespace SchoolSys;

public class Person
{
    public string name { get; set; }

    public Person( string name)
    {
        this.name = name;
    }
}

public class Student : Person
{
    public int UniqueNumber { get; set; }

    public Student(string name, int uniqueNumber) : base(name)
    {
        UniqueNumber = uniqueNumber;
    }
}

public class Teacher : Person
{
    public List<Course> Courses { get; set; }

    public Teacher(string name) : base(name)
    {
        Courses = new List<Course>();
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}

public class Course
{
    public string Name { get; set; }
    public int ClassCount { get; set; }
    public int ExerciseCount { get; set; }

    public Course(string name, int classCount, int exerciseCount)
    {
        Name = name;
        ClassCount = classCount;
        ExerciseCount = exerciseCount;
    }
}

public class ClassRoom
{
    public string Identifier { get; set; }
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }

    public ClassRoom(string identifier)
    {
        Identifier = identifier;
        Students = new List<Student>();
        Teachers = new List<Teacher>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }
}

public class School
{
    public List<ClassRoom> Classes { get; set; }

    public School()
    {
        Classes = new List<ClassRoom>();
    }

    public void AddClass(ClassRoom classRoom)
    {
        Classes.Add(classRoom);
    }
}