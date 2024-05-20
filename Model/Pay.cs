using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Model
{
    public class Pay
    {
        private decimal hoursWorked {  get; set; }
        private Employee employee { get; set; }

        public decimal salary { get; set; }

        public Pay(decimal hoursWorked, Employee employee, decimal salary)
        {
            this.hoursWorked = hoursWorked;
            this.employee = employee;
            this.salary = salary;
        }

        public decimal CalculatePayRoll(Employee employee)
        {
            salary = hoursWorked * employee.HourlySalary;
            return salary;
        }
    }
}
