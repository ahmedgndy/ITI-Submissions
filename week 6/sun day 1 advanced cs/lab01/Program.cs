namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeesManager m1 = new EmployeesManager();

            Employee emp1 = m1[122] as Employee;
            if (emp1 != null)
            {
                Console.WriteLine($"{emp1.Id} {emp1.FirstName} {emp1.Privileges}");
            }
            HireData em1HiredDate = new HireData(1, 10, 2010);
            Employee emp2 = m1[em1HiredDate] as Employee;

            if (emp2 != null)
            {
                Console.WriteLine($"{emp2.Id} {emp2.FirstName} {emp2.Privileges}");

            }

            Employee emp3 = m1["Ahmed"];
            Console.WriteLine($"{emp3.Id} {emp3.FirstName} {emp3.Privileges}");

        }
       
    }
}
