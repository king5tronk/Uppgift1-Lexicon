namespace Uppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("\nWelcome to the Employee Management System!");
                Console.WriteLine("Type 1 to add an employee, 2 to view all employees, or 3 to exit.");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter employee name (or 'exit' to go back to menu):");
                        string name = Console.ReadLine();
                        if (name.ToLower() == "exit") break;

                        Console.WriteLine("Enter employee salary as integer (ex: 20000): ");
                        int salary;
                        while (!int.TryParse(Console.ReadLine(), out salary))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid salary:");
                        }

                        employees.Add(new Employee(name, salary));
                        Console.WriteLine("Employee added!\n");
                    }
                }
                else if (choice == "2")
                {
                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees registered yet.");
                    }
                    else
                    {
                        Console.WriteLine("\nEmployee List:");
                        foreach (var emp in employees)
                        {
                            Console.WriteLine($"Namn: {emp.Name}, Lön: {emp.Salary} kr");
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Exiting the program. Bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
