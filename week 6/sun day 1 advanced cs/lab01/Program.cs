namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //hiredData 
                HireData em1HiredDate = new HireData(1, 10, 2010);
                HireData em2HiredDate = new HireData(1, 9, 2006);
                HireData em3HiredDate = new HireData(1, 10, 2007);

                //employees 
                Employee employee1 = new Employee("Ahmed", 1000, em1HiredDate, Gender.male, Privileges.developer);
                Employee employee2 = new Employee("Zahra", 1000, em2HiredDate, Gender.female, Privileges.secreary);

                // doesn't  make a sence to give a guesst a hiredData 
                Employee employee3 = new Employee("AhmedDuplicated", 1000, em3HiredDate, Gender.male, Privileges.guest);

                //array of size 3 
                Employee[] employees = { employee1, employee2, employee3 };

                Array.Sort(employees);

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.FirstName);

                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                Console.WriteLine("finally in cs will runs also there is a problem or not ");
            }

        }
        static bool  CompareHiringData(Employee emp1 , Employee emp2 )

        {

            return false;
        }
    }
}
