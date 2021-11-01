using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioContract.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { set; get; }
        public int Hours { set; get; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
