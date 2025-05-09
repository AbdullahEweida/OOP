//Define a base class called Worker that has two derived classes: Employee and Manager. 
//For workers, we only have simple attributes such as their names and working hours. 
//For employees and managers, each has specific attributes unique to the class. 
//Employees have attributes such as the name of the department that they are working with, and their salaries. 
//Managers have attributes such as the number of managed employees and the number of projects that they’re in charge. 
//Also, define another class called Project that has attributes such as the name and the current progress (in %) of the project.
//(1) Write the corresponding constructors that initialize the attributes for classes.
//(2) Write the corresponding member functions to set and get the attributes for classes.
//(3) Finally, test the classes in a main program. In the test program, you should dynamically allocate some employees and managers, print their corresponding information.
using WorkerClasses;
List<Worker> workers = new List<Worker>();

Worker emp1 = new Employee("Ali", 40, "IT", 5000);
Worker emp2 = new Employee("Sara", 35, "HR", 4500);

Worker mgr1 = new Manager("Hassan", 50, 5, 3);
Worker mgr2 = new Manager("Lina", 45, 8, 2);

workers.Add(emp1);
workers.Add(emp2);
workers.Add(mgr1);
workers.Add(mgr2);

foreach (var worker in workers)
{
    worker.DisplayInfo();
    Console.WriteLine("----------");
}

Project project = new Project("System Upgrade", 75);
project.DisplayInfo();