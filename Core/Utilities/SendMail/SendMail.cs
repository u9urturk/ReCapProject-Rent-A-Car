using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.Utilities.SendMail
{
    public  class SendMail:ISendMail
    {
        public   bool Send(string MailContent)
        {
            try
            {
                
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential("dened9761@gmail.com","password" );
                // mail göndermek için oturum açtık

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(); // yeni mail oluşturduk
                mail.From = new System.Net.Mail.MailAddress("dened9761@gmail.com","ADMIN"); // maili gönderecek hesabı belirttik
                mail.To.Add("l4rnxy@gmail.com"); // mail gönderilecek adresi belirledik
                mail.Subject = "<->  Sistem Performansı <->"; // mailin konusu
                
                mail.Body = MailContent; // mailin içeriği
                
               
                // göndereceğimiz maili hazırladık.

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com",587); // smtp servere bağlandık
                smtp.UseDefaultCredentials = false; // varsayılan girişi kullanmadık
                smtp.EnableSsl = true; // ssl kullanımına izin verdik
                smtp.Credentials = cred; // server üzerindeki oturumumuzu yukarıda belirttiğimiz NetworkCredential üzerinden sağladık.
                smtp.Send(mail); // mailimizi gönderdik.
               

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
