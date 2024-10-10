using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace RegIN_Subbotin.Classes
{
    public class SendMail
    {
        public static void SendMessage(string Message, string To)
        {
            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {
                Port = 587,
                Credentials = new NetworkCredential("screamtoxic@yandex.ru", "grihanatoper123"),
                EnableSsl = true,
            };
            smtpClient.Send("screamtoxic@yandex.ru", To, "Проект RegIN_Subbotin", Message);
        }
    }
}
