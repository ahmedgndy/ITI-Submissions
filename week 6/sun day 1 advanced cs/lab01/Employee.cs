using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class  Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public decimal Salary{ get; set; } 

        public HireData Hiredata {  get; set; }

        public Gender Gender { get; set; }

        public Privileges Privileges { get; set; }

        public Employee( string fristName, int id ,decimal salary, HireData hiredata ,Gender gender = Gender.male, Privileges privileges = Privileges.guest) {
          
            this.Id = id;

            this.FirstName = fristName;
            this.Salary = salary;
            this.Hiredata = hiredata;
            this.Gender = gender;
            this.Privileges = privileges;

        }

        //indexer 
      
        public int CompareTo(Employee other)
        {
            return this.Hiredata.HiringDate.CompareTo(other.Hiredata.HiringDate);
        }
        public override string ToString()
        {
            return Salary.ToString();
        }

    }
}
