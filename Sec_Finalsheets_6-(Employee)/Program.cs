using EmployeeClasses;

Employee [] employees = new Employee[]{
    new SalariedEmployee(5000,"Abdurahman Mahmoud"),
    new CommissionEmployee(55,"Ahmed maher",50),
    new HourlyEmployee(50.5m,"Hamed Nasef",25),
    new CommissionEmployeePlusSalaried(69.8m,"Ahmed mahmoud", 50, 4500)
};
for (int i = 0; i < employees.Length; i++)
{
    employees[i].DisplayInfo();
    Console.WriteLine("-------------------------------");
}