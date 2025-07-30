namespace Emplooyee_day_6_lab
{

    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    class HiringDate
    {
        public int Day;
        public int Month;
        public int Year;

        public HiringDate(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }

        public int CompareTo(HiringDate other)
        {
            if (Year != other.Year)
                return Year.CompareTo(other.Year);
            else if (Month != other.Month)
                return Month.CompareTo(other.Month);
            else
                return Day.CompareTo(other.Day);
        }

        public override string ToString()
        {
            return Day + "/" + Month + "/" + Year;
        }
    }

    class Employee
    {
        public int ID;
        public string Name;
        public char Gender; // Only M or F
        public SecurityLevel Security;
        public double Salary;
        public HiringDate HireDate;

        public Employee(int id, string name, char gender, SecurityLevel security, double salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;

            if (gender == 'M' || gender == 'F')
                Gender = gender;
            else
                Gender = 'M'; 

            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return "ID: " + ID +
                ", Name: " + Name +
                ", Gender: " + Gender +
                ", Security Level: " + Security +
                ", Salary: " + Salary.ToString("C") +
                ", Hire Date: " + HireDate.ToString();
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(101, "Ali", 'M', SecurityLevel.DBA, 15000, new HiringDate(10, 5, 2022));
            EmpArr[1] = new Employee(102, "Laila", 'F', SecurityLevel.Guest, 8000, new HiringDate(15, 8, 2023));
            EmpArr[2] = new Employee(103, "Omar", 'M', SecurityLevel.SecurityOfficer, 20000, new HiringDate(1, 1, 2021));

            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                for (int j = i + 1; j < EmpArr.Length; j++)
                {
                    if (EmpArr[i].HireDate.CompareTo(EmpArr[j].HireDate) > 0)
                    {
                        Employee temp = EmpArr[i];
                        EmpArr[i] = EmpArr[j];
                        EmpArr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted Employees by Hire Date:");
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i].ToString());
            }

            Console.WriteLine("\nBoxing might happen in ToString and CompareTo methods.");
        }
    }
}
    


