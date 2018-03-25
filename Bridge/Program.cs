using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Email email=new EmailSender("Subject","Body");
            email.EmailManager=new WcfEmailSender();
            email.Send();
            email.EmailManager=new WebApiEmailSender();
            email.Send();
        }
    }
    //**********************************************************
    public abstract class Email
    {
        public abstract void Send();
        public string Subject { get; set; }
        public string Body { get; set; }

        protected IEmailManager _emailManager;
        public IEmailManager EmailManager {
            get { return _emailManager; }
            set { _emailManager = value; }
        }
    }
    //**********************************************************
    public class EmailSender:Email
    {
        public EmailSender(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }

        public override void Send()
        {
            _emailManager.Sender(Subject,Body);
        }
    }

    //**********************************************************
    public interface IEmailManager
    {
        void Sender(string subject,string body);
    }

    //**********************************************************
    public class WcfEmailSender:IEmailManager
    {
        public void Sender(string subject, string body)
        {
            Console.WriteLine("SEnd With WCF");
        }
    }
    //**********************************************************
    public class WebApiEmailSender : IEmailManager
    {
        public void Sender(string subject, string body)
        {
            Console.WriteLine("SEnd With WebApi");
        }
    }
    //**********************************************************

}
