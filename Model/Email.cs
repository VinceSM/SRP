using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Model
{
    public class Email
    {
        public void SendEmail(Employee employee, string subject, string message, Action<string> logAction)
        {
            string detalle = $"Enviando Correo a '{employee.Name}'Asunto: '{subject}'Mensaje: '{message}'";
            logAction(detalle);
        }
    }
}
