using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOEDI.Classes
{
    public class Date
    {
        #region Fields
        private int _year; 
        private int _month;
        private int _day;
        #endregion

        #region Methods

        public Date(int year,int month,int day)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day,month,year);

        }

        private int ValidateDay(int day, int month, int year)
        {
            if (month  == 2 && day == 29 && IsleapYear(year)) 
            {
                return day;
            }

            if (month == 2 && day == 29 && IsleapYear(year))
            {
                bool isleapYear = false;
                IsleapYearExecption(isleapYear, year);
                
            }
          
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else 
            {
                throw new DayExeption(String.Format("El dia {0} no es valido para el mes {1}", day,month));
            }

        }
        private void IsleapYearExecption(bool isleapYear, int year)
        {
            if (!isleapYear)
            {
                throw new YearExeption(String.Format("El año  {0} no es bisiesto", year));
            }
        }
        private bool IsleapYear(int year) 
        {
            bool isleapYear = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            return isleapYear;
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900) 
            {
                return year;   
            }
            else
            {
                throw new YearExeption(String.Format("El año  {0} no es valido", year));
            }

           
        }

        private int ValidateMonth(int month)
        {
            
            if (month >= 1 && month <= 12) 
            {
                return(month);
            }
            else
            {
                throw new MonthExeption(String.Format("El mes {0} no es valido",month));   // exception creation
            }                                       
        }
        #endregion
        public override string ToString()
        {           
            var dateConcatenatedd1 = _year +"/" + _month +"/" +_day ;
            var dateConcatenatedd2 = $"{_day:00}/{_month:00}/{_year:0000}";
            var dateConcatenatedd3 = string.Format("{0:00}/{1:00}/{2:0000}" , _day, _month, _year);
            return dateConcatenatedd3;
        }


    }
}
