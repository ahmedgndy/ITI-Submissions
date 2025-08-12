using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal struct HireData 
    
    {
        private int _day ;
        private int _month; 

        private  int _year ;

        public DateTime HiringDate { get;  set; }

        public HireData(int day  , int month , int year ) {
            _day = _month = 1; // safe defaults
            _year = DateTime.Now.Year;

            this.Day = day;
            this.Month = month;
            this.Year = year;
            try
            {
                this.HiringDate = new DateTime(this.Year, this.Month, this.Day);
            }
            catch (ArgumentOutOfRangeException ex) { 
               Console.WriteLine(ex.Message);
            }
        }

        public int Day { 
        
            get { return _day; }
            set {
                if (value >= 1 && value <= 31)
                {
                    _day = value;
                }
                else { 
                    //handel 
                    throw new ArgumentOutOfRangeException(nameof(value) ,"Day must be Between 1 and 31 :");
                }
                    
            }
        }


        public int Month
        {

            get { return _month; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    _month = value;
                }
                else
                {
                    //handel 
                    throw new ArgumentOutOfRangeException(nameof(value), "Month  must be Between 1 and 12 ");
                }

            }
        }

        public int Year
        {

            get { return _year; }
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value >= 2000 && value <= currentYear)
                {
                    _year  = value;
                }
                else
                {
                    //handel 
                    throw new ArgumentOutOfRangeException(nameof(value), $"Year  must be Between 2000 and 12 ${currentYear}");
                }

            }
        }

        public static bool operator == (HireData a, HireData b) {

             if (a.HiringDate == b.HiringDate)  { return true; }
             return false;
        }

        public static bool operator !=(HireData a, HireData b)
        {
            
             if (a.HiringDate != b.HiringDate)  { return true; }
             return false;
        }



    }
}
