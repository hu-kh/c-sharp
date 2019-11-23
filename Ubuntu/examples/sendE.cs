using System;
using System.Net.Mail;
using System.Net;


namespace MainProgramm
{
   class Program
   {
      static void Main(string[] args)
      {
	string host = "0.0.0.0";
	int port = 25;
	string userName = "user@user.com";
	string password = "password";
	string from = userName;

	var client = new SmtpClient
	{
	    Host = host,
	    Port = port,
	    EnableSsl = true,
	    DeliveryMethod = SmtpDeliveryMethod.Network,
	    UseDefaultCredentials = false,
	    Credentials = new NetworkCredential(userName, password)
	};

	MailMessage mailMessage = new MailMessage();
	mailMessage.From = new MailAddress(from);
	mailMessage.To.Add(userName);
	mailMessage.Body = "This is test mail.";
	mailMessage.Subject = "Testing";                
	client.Send(mailMessage);

        Console.ReadKey();
       }
   } 
}

