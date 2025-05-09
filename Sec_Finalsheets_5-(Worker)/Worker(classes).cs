namespace WorkerClasses
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public decimal HoursWorked { get; set; }

        public Worker(string name, decimal hoursWorked)
        {
            Name = name;
            HoursWorked = hoursWorked;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Hours Worked: {HoursWorked}");
        }
    }

    public class Employee : Worker
    {
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal hoursWorked, string department, decimal salary)
            : base(name, hoursWorked)
        {
            Department = department;
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Department: {Department}, Salary: {Salary}");
        }
    }

    public class Manager : Worker
    {
        public int ManagedEmployees { get; set; }
        public int NumberOfProjects { get; set; }

        public Manager(string name, decimal hoursWorked, int managedEmployees, int numberOfProjects)
            : base(name, hoursWorked)
        {
            ManagedEmployees = managedEmployees;
            NumberOfProjects = numberOfProjects;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Managed Employees: {ManagedEmployees}, Projects: {NumberOfProjects}");
        }
    }

    public class Project
    {
        public string Name { get; set; }
        public int Progress { get; set; }

        public Project(string name, int progress)
        {
            Name = name;
            Progress = progress;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Project Name: {Name}, Progress: {Progress}%");
        }
    }
}