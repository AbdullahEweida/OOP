namespace Student;

public class GetStudent
{
    public string FullName { get; set; }
    public string Course { get; set; }
    public string Subject { get; set; }
    public string University { get; set; }
    public string Email { get; set; }
    public double Phone { get; set; }
    private static int Count = 1;
    public GetStudent(string FullName, string Course, string Subject, string University, string Email, double Phone)
    {
        this.FullName = FullName;
        this.Course = Course;
        this.Email = Email;
        this.Phone = Phone;
        this.University = University;
        this.Subject = Subject;
        CalculateNumberOfObject();
    }
    public GetStudent(string FullName, string Course, string Subject)
    {
        this.FullName = FullName;
        this.Course = Course;
        Email = null;
        Phone = 0;
        University = null;
        this.Subject = Subject;
        CalculateNumberOfObject();
    }
    static void CalculateNumberOfObject()
    {
        Console.WriteLine($"The number of objects equal {Count}");
        Count++;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Full name : {FullName}");
        Console.WriteLine($"Course : {Course}");
        Console.WriteLine($"Subject : {Subject}");
        if(Email != null)
        {
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"University : {University}");
        }
    }

}
