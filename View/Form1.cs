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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSaveInfo.Click += BtnSaveInfo_Click;
            btnSendEmail.Click += BtnSendEmail_Click;
        }

        private void BtnSaveInfo_Click(object sender, EventArgs e)
        {
            string name = txtNameEmp.Text;
            string position = txtPosition.Text;
            decimal hourlySalary = decimal.Parse(txtHsSalary.Text);
            decimal hoursWorked = decimal.Parse(txtHsWoked.Text);

            Employee employee = new Employee(name, position, hourlySalary);
            Pay pay = new Pay(employee, hoursWorked);

            decimal salary = pay.CalculatePayRoll();
            

            txtDetailsEmployee.Text = $"Nombre: {employee.Name}{Environment.NewLine}" + 
                                      $"Posición: {employee.Position}{Environment.NewLine}" +
                                      $"Salario por hora: {employee.HourlySalary}{Environment.NewLine}" +
                                      $"Horas trabajadas: {hoursWorked}{Environment.NewLine}" +
                                      $"Salario calculado: {salary:F2}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}";
        }

        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            string name = txtNameEmp.Text;
            string position = txtPosition.Text;
            decimal hourlySalary = decimal.Parse(txtHsSalary.Text);

            Employee employee = new Employee(name, position, hourlySalary);
            Email email = new Email();

            string subject = $"Informe de Salario{Environment.NewLine}";
            string message = $"Estimado {employee.Name}," +
                             $"{Environment.NewLine}Su informe de salario está disponible." +
                             $"Atte, Equipo de Recursos Humanos";

            email.SendEmail(employee, subject, message, log =>
            {
                txtDetailsEmployee.AppendText("\n\n" + log);
            });
        }
    }
}
