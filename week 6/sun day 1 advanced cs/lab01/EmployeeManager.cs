using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class EmployeesManager
    {
        private Employee[] _employees;
        int CurrentIndex ;
       public EmployeesManager()
        {
            try
            {
                //hiredData 
                HireData em1HiredDate = new HireData(1, 10, 2010);
                HireData em2HiredDate = new HireData(1, 9, 2006);
                HireData em3HiredDate = new HireData(1, 10, 2007);

                //employees 
                Employee employee1 = new Employee("Ahmed", 124, 123, em1HiredDate, Gender.male, Privileges.developer);
                Employee employee2 = new Employee("Zahra", 122, 122, em2HiredDate, Gender.female, Privileges.secreary);

                // doesn't  make a sence to give a guesst a hiredData 
                Employee employee3 = new Employee("AhmedDuplicated", 111, 111, em3HiredDate, Gender.male, Privileges.guest);

                //array of size 3 
                _employees = [employee1, employee2, employee3];

                Array.Sort(_employees);

                foreach (Employee employee in _employees)
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

        public void AddEmployee(Employee emp) {
            _employees[CurrentIndex] = emp;
        }
       
        public Employee? this[int id] {

            get {
                for (int i = 0; i < _employees.Length; i++) {
                    if (_employees[i].Id == id) { 
                        return _employees[i];
                    }
                }
                return null;
            }
        
        }

        public Employee? this[string name] {
            get
            {
                for (int i = 0; i < _employees.Length; i++)
                {
                    if (_employees[i].FirstName == name)
                    {
                        return _employees[i];
                    }
                }
                return null;
            }
        }

        public Employee? this[HireData hireData]
        {
            get
            {
                for (int i = 0; i < _employees.Length; i++)
                {
                    if (_employees[i].Hiredata == hireData)
                    {
                        return _employees[i];
                    }
                }
                return null;
            }
        }
    }
}
