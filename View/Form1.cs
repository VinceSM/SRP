using SRP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRP
{
    partial class Form1 : Form
    {
        private Employee employee;
        private Pay pay;
        private Email email;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {

            decimal hoursWorked = decimal.Parse(txtHsWoked.Text);
            decimal hourlySalary = decimal.Parse(txtHsSalary.Text);
            employee = new Employee(txtNameEmp.Text, txtPosition.Text, hourlySalary);
            pay = new Pay(hoursWorked, employee, 0);
            decimal salary = pay.CalculatePayRoll(employee);
            txtSalary.Text = salary.ToString();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
                txtDetailsEmployee.Text = $"Name: {txtNameEmp.Text}" +
                $"\r\nPosition: " +
                $"{txtPosition.Text}\r\nHours Worked: " +
                $"{txtHsWoked.Text}\r\nHourly Salary: " +
                $"{txtHsSalary.Text}\r\nTotal Salary: " +
                $"{txtSalary.Text}";

                email.SendEmail(employee, subject, message, detalle, logAction);

        }
    }
}
