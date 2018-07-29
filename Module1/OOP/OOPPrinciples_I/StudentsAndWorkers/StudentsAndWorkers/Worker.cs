using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / 7 / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("Worker: {0} {1} with WeekSalary: {2} and WorkHoursPerDay: {3}\n", 
                this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
