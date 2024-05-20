using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Model
{
    public class Email
    {
        private Employee employee;
        private string subject;
        private string message;
        private string detalle;

        public void SendEmail(Employee employee, string subject, string message, string detalle, Action<String> logAction)
        {
            detalle = $"Enviando Correo a '{employee.Name}'. Asunto '{subject}'. Mensaje '{message}' ";
            logAction(detalle);
        }
    }
}
