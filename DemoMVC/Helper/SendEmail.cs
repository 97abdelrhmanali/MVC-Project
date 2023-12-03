using DemoDAL.Model;
using System.Net;
using System.Net.Mail;

namespace DemoMVC.Helper
{
	public static class EmailSettings
	{
		public static void SendEmail(Email email)
		{
			var client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl= true;
			client.Credentials = new NetworkCredential("amednaser975@gmail.com", "tlcoetonlbelmepr");
			client.Send("amednaser975@gmail.com", email.Recipients, email.Subject, email.Body);
		}
	}
}
