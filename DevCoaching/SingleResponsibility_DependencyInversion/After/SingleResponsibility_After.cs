using Microsoft.Extensions.Logging;

namespace DevCoaching.Single_Responsibility.After
{
    public class SingleResponsibility_After
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IEmailer _emailer;
        private readonly ILogger<SingleResponsibility_After> _logger;
        private readonly IPackageValidator _packageValidator;
        private readonly IPaymentProviderProvider _paymentProviderProvider;

        public SingleResponsibility_After(
            IServiceProvider serviceProvider,
            IEmailer emailer,
            ILogger<SingleResponsibility_After> logger,
            IPackageValidator packageValidator,
            IPaymentProviderProvider paymentProviderProvider)
        {
            _paymentProviderProvider = paymentProviderProvider;
            _packageValidator = packageValidator;
            _logger = logger;
            _emailer = emailer;
            _serviceProvider = serviceProvider;
        }

        public void ProcessRequest(Request request)
        {
            _logger.LogDebug($"Validating request ID {request.Id}");
            _packageValidator.Validate(request);
            
            _logger.LogDebug($"Starting processing ID {request.Id}");
            _paymentProviderProvider
                .Provide(request.PaymentProviderType)
                .MakePayment(request.Amount);
            
            _logger.LogDebug($"Emailing {request.RecipientEmail}");
            _emailer.SendEmail("sender@example.app", "recipient@example.app", "Pament made", "Your item has been dispatched and your card has been charged.");

            _logger.LogDebug($"Finished processing ID {request.Id}");
        }

        public interface IPackageValidator
        {
            void Validate(Request request);
        }

        public class PackageValidator : IPackageValidator
        {
            public void Validate(Request request)
            {
                if ((request.PackageHeight * request.PackageWidth * request.PackageDepth) > 1000)
                {
                    throw new Exception("Volume can't be more than 1000 square centimeters");
                }

                if (request.PackageWidth > 15 || request.PackageDepth > 15 || request.PackageHeight > 15)
                {
                    throw new Exception("Length cannot be greater than 15cm");
                }
            }
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

        public interface IEmailer
        {
            void SendEmail(string toAddress, string from, string subject, string body);
        }

        public class Emailer : IEmailer
        {
            public void SendEmail(string to, string from, string subject, string body)
            {
                // leave logic blank
            }
        }

        public interface IPaymentProviderProvider
        {
            IPaymentProvider Provide(PaymentProviderType type);
        }

        public enum PaymentProviderType
        {
            Stripe,
            WorldPay
        }

        public interface IPaymentProvider
        {
            void MakePayment(decimal amount);
        }

        public interface IStripePaymentProvider : IPaymentProvider
        {

        }

        public interface IWorldPayPaymentProvider : IPaymentProvider
        {

        }

        public class PaymentProviderProvider
        {
            private readonly IServiceProvider _serviceProvider;

            public PaymentProviderProvider(IServiceProvider serviceProvider)
            {
                _serviceProvider = serviceProvider;
            }

            public IPaymentProvider Provide(PaymentProviderType type)
            {
                switch (type)
                {
                    case PaymentProviderType.Stripe:
                        return GetService<IStripePaymentProvider>();
                    case PaymentProviderType.WorldPay:
                        return GetService<IWorldPayPaymentProvider>();
                    default:
                        throw new Exception("Invalid Provider");
                }
            }

            protected T GetService<T>() => (T)_serviceProvider.GetService(typeof(T));
        }

    }
}
