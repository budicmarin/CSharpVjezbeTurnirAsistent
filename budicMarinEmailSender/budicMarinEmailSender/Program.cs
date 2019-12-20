using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace budicMarinEmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            try//hvatanje greške 
            {
                Console.Write("From: ");
                string emailKlijenta=Console.ReadLine()//upis emaila koji šalje
                Console.Write("\nUsername: ");
                string username = Console.ReadLine();//upis usernamea
                Console.Write("\nPassword: ");
                string password = Console.ReadLine();//upis zaporke
                Console.Write("\nTo: ");
                string dolazniEmail=Console.ReadLine();//upis emaila koji prima
                Console.Write("\nSubject: ");//upis tema
                string subject = Console.ReadLine();
                Console.Write("\nBody: ");//upis maila
                string body = Console.ReadLine();
                MailMessage mail = new MailMessage(); // kreirane istance Objekta MailMessage koji služi za slanje maila

                
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); //kreiranje istance objekta SmtpClient 
                //Smtp  je protokol za slanje e-mail-ova

                mail.From = new MailAddress(emailKlijenta);//dodavanje adrese s koje se šalje mail
                mail.To.Add(dolazniEmail);//dodavanje adrese na koju mail ide
                mail.Subject =subject;//Dodovanje opisa maila
                mail.Body = body;//mail

                SmtpServer.Port = 587;//port smtpservera u mreži
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);//zaprka i korisničko ime klijenta koji šalje mail
                SmtpServer.EnableSsl = true; //uključivanje ssl protokola

                SmtpServer.Send(mail);//mail se šalje
                Console.WriteLine("mail Send");//povratna poruka
                Console.ReadKey();
            }
            catch (Exception ex) //ispis greške
            {
                Console.WriteLine(ex.ToString());//ispis greške
            }
        }
    }
}
