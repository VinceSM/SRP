using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Model
{
    public class Pay
    {
        private decimal hoursWorked { get; set; }
        private Employee employee { get; set; }

        public Pay(Employee employee, decimal hoursWorked)
        {
            this.employee = employee;
            this.hoursWorked = hoursWorked;
        }

        public decimal CalculatePayRoll()
        {
            return hoursWorked * employee.HourlySalary;
        }
    }
}
