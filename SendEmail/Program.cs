using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmail
{
    class Program
    {

        static void Main(string[] args)
        {
            //Email người gửi
            string fromMail = "loveyou15102002@gmail.com";

            //Lấy trong App Password của Google Security
            //Google Account -> Bảo mật -> Đăng nhập với Google -> Mật khẩu ứng dụng (
            //Nếu chưa xác minh 2 bước sẽ không hiện) -> Tạo App Password cho Mail chọn Device
            //là máy tính => sẽ có app Password

            string fromPassword = "kmchsnvnzfvtfwpd";

            MailMessage message = new MailMessage();

            
            message.From = new MailAddress(fromMail);
            message.Subject = "Text Subject";
            message.To.Add(new MailAddress("20522093@gm.uit.edu.vn"));
            message.Body = "<html><body>Thank you for pucharsing my product</body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail,fromPassword),
                EnableSsl = true
            };

            //Gửi đoạn mail
            smtpClient.Send(message);

        }
    }
}
