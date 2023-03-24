using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Single_Responsibility.Before
{
    public class SingleResponsibility_Before
    {
        public void ProcessRequest(Request request)
        {
            // Check package volume
            Console.WriteLine($"Validating request ID {request.Id}");
            if ((request.PackageHeight * request.PackageWidth * request.PackageDepth) > 1000)
            {
                throw new Exception("Volume can't be more than 1000 square centimeters");
            }

            if (request.PackageWidth > 15 || request.PackageDepth > 15 || request.PackageHeight > 15)
            {
                throw new Exception("Length cannot be greater than 15cm");
            }

            Console.WriteLine($"Starting processing ID {request.Id}");
            if (request.PaymentProviderType == PaymentProviderType.Stripe)
            {
                var provider = new StripePaymentProvider();
                provider.MakePayment(request.Amount);
                Console.WriteLine($"Using Stripe to process ID {request.Id}");
            }
            else if (request.PaymentProviderType == PaymentProviderType.WorldPay)
            {
                var provider = new WorldPayPaymentProvider();
                provider.MakePayment(request.Amount);
                Console.WriteLine($"Using World Pay to process ID {request.Id}");
            }
            else
            {
                throw new Exception("Invalid payment method");
            }


            Console.WriteLine($"Emailing {request.RecipientEmail}");
            new Emailer().SendEmail("sender@example.app", "recipient@example.app", "Pament made", "Your item has been dispatched and your card has been charged.");

            Console.WriteLine($"Finished processing ID {request.Id}");
        }

        public class Request
        {
            public Guid Id { get; set; }
            public PaymentProviderType PaymentProviderType { get; set; }
            public string RecipientEmail { get; set; }
            public decimal Amount { get; set; }

            public decimal PackageHeight { get; set; }
            public decimal PackageWidth { get; set; }
            public decimal PackageDepth { get; set; }
        }

        public class Emailer
        {
            public void SendEmail(string to, string from, string subject,string body)
            {
                // leave logic blank
            }
        }

        public class StripePaymentProvider
        {
            public void MakePayment(decimal amount)
            {
                // leave logic blank
            }
        }

        public class WorldPayPaymentProvider
        {
            public void MakePayment(decimal amount)
            {
                // leave logic blank
            }
        }

        public enum PaymentProviderType
        {
            Stripe,
            WorldPay
        }

    }
}
