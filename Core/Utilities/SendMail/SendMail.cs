using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Core.Utilities.SendMail
{
    public  class SendMail:ISendMail
    {
        public   bool Send(string GMailHesabi, string GMailHesapSifresi, string GMailUnvan,string AMailHesabi , string MailKonu, string MailIcerik,  string Pop3Host, int Pop3Port)
        {
            try
            {
                System.Net.NetworkCredential cred = new System.Net.NetworkCredential(GMailHesabi,GMailHesapSifresi);
                // mail göndermek için oturum açtık

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(); // yeni mail oluşturduk
                mail.From = new System.Net.Mail.MailAddress(GMailHesabi,GMailUnvan); // maili gönderecek hesabı belirttik
                mail.To.Add(AMailHesabi ); // mail gönderilecek adresi belirledik
                mail.Subject = MailKonu; // mailin konusu
                
                mail.Body = MailIcerik; // mailin içeriği
                
               
                // göndereceğimiz maili hazırladık.

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(Pop3Host, Pop3Port); // smtp servere bağlandık
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
