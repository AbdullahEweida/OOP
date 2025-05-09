//*Define a class Human with properties "first name" and "last name".
//*Define the class Student inheriting Human,which has the property "mark".
//*Define the class Worker inheriting Human with the property "wage" and "hours worked".
//*Implement a "calculate hourly wage" method, which calculates a worker’s hourly pay rate based on wage and hours worked.
//*Write the corresponding constructors and encapsulate all data in properties.
using HumansData;

Worker [] workers = new Worker[]{
    new Worker("Abdullah","Eweida",120,6),
    new Worker("Ahmed","El-Mansory",62.5m,0),
    new Worker("Kareem","Nafe3",130,10)};

Student [] students = new Student[]{ 
    new Student("Amr","Mahmoud",96),
    new Student("Mahmoud","Mohamed",45)};

Console.WriteLine("\tWorkers");
foreach (var worker in workers)
{
    Console.WriteLine($"full name : {worker.firstName} {worker.lastName}");
    Console.WriteLine($"Wage : {worker.wage}$ \t Hours worked : {worker.hoursWorked} ");
    Console.WriteLine($"hourly wage : {worker.CalculateHourlyWage()}");
    Console.WriteLine("-------------------------------------");    
}

Console.WriteLine("\tStudents");
foreach (var student in students)
{
    Console.WriteLine($"full name : {student.firstName} {student.lastName} \nYour mark : {student.Mark}");
    Console.WriteLine("-------------------------------------");
}