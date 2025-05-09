namespace HumansData;
//Define a class Human with properties "first name" and "last name".
public abstract class Human
{
    public string firstName {get; set;}

    public string lastName {get; set;}
    public Human(string _firstName,string _lastName)
    {
        this.firstName = _firstName;
        this.lastName = _lastName; 
    }
}
//Define the class Student inheriting Human,which has the property "mark".
public class Student : Human
{
    public decimal Mark {get; set;}
    public Student(string firstName,string lastName,decimal mark) : base(firstName, lastName)
    {
     Mark = mark;   
    }
}
//Define the class Worker inheriting Human with the property "wage" and "hours worked".
//Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours worked.
public class Worker : Human
{

    public decimal wage {get; set;}
    public decimal hoursWorked {get; set;}
    public Worker(string firstName,string lastName,decimal _wage,decimal _hoursWorked) : base(firstName, lastName){
      this.wage = _wage;
      this.hoursWorked = _hoursWorked;   
    }
    public decimal CalculateHourlyWage() => (hoursWorked != 0) ? wage / hoursWorked : 0; 
}