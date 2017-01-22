using AirPlane.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirPlane.Domain.Entities;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace AirPlane.Domain.Concrete
{
   public class EmailSettings   
    {
        public string MailToAddress = "daw2@o2.pl";
        public string MailFromAddress = "daw2@o2.pl";
        public bool UseSsl = true;
        public string Username = "daw2";
        public string Password = "odra2007";
        public string ServerName = "poczta.o2.pl";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = @"d:\sports_store_emails";

    }

    public class EmailOrderProcessor : IOrderProcessor
    {
        private EmailSettings emailSettings;
        public EmailOrderProcessor(EmailSettings settings)
        {
            
            emailSettings = settings;
        }
        public void ProcessOrder(Cart cart, ShippingDetails shippingInfo)
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.EnableSsl = emailSettings.UseSsl;
                smtpClient.Host = emailSettings.ServerName;
                smtpClient.Port = emailSettings.ServerPort;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials
                = new NetworkCredential(emailSettings.Username,
                emailSettings.Password);

                if (emailSettings.WriteAsFile)
                {
                    smtpClient.DeliveryMethod
                    = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    smtpClient.PickupDirectoryLocation =
                    emailSettings.FileLocation;
                    smtpClient.EnableSsl = false;
                }
                StringBuilder body = new StringBuilder()
                .AppendLine("A new order has been submitted")
                .AppendLine("---")
                .AppendLine("Items:");
                foreach (var line in cart.Lines)
                {
                    var subtotal = line.Product.EngineCnt* line.Quantity;
                    body.AppendFormat("{0} x {1} (subtotal: {2:c}",
                    line.Quantity,
                    line.Product.Name,
                    subtotal);
                }
                body.AppendFormat("Total order value: {0:c}",
                cart.ComputeTotalValue())
                .AppendLine("---")
                .AppendLine("Ship to:")
                .AppendLine(shippingInfo.Name)
                .AppendLine(shippingInfo.Line1)
                .AppendLine(shippingInfo.Line2 ?? "")
                .AppendLine(shippingInfo.Line3 ?? "")
                .AppendLine(shippingInfo.City)
                .AppendLine(shippingInfo.State ?? "")
                .AppendLine(shippingInfo.Country)
                .AppendLine(shippingInfo.Zip)
                .AppendLine("---")
                .AppendFormat("Gift wrap: {0}",
                shippingInfo.GiftWrap ? "Yes" : "No");
                MailMessage mailMessage = new MailMessage(
                emailSettings.MailFromAddress,
                emailSettings.MailToAddress,
                "New order submitted!",
                body.ToString());

                Stream stream = new System.IO.MemoryStream(cart.lineCollection[0].Product.FullImage.HighResolutionBits, false);


                mailMessage.Attachments.Add(new Attachment(stream, "Image", "image/jpeg"));


                if (emailSettings.WriteAsFile)
                {
                    mailMessage.BodyEncoding = Encoding.ASCII;
                }
                try
                {
                smtpClient.Send(mailMessage);
                }
                catch(Exception ex )
                {
                    string s = ex.Message.ToString();
                }
           
            }
            }
    }
}
