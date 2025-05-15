namespace StudentMangement;

public class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public Student(int ID, string Name, int Age, string Grade)
    {
        this.ID = ID;
        this.Age = Age;
        this.Grade = Grade;
        this.Name = Name;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Info ({ID})");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age : {Age}");
        Console.WriteLine($"Grade : {Grade}");
    }
    public void UpdateGrade(string newGrade)
    {
        Grade = newGrade;
        Console.WriteLine($"{Name}'s grade has been updated to {Grade}");
    }
}
