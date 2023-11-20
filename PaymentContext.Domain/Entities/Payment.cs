using PaymentContext.Domain.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment : Entity
    {
        public Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, int payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            this.totalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;

            AddNotifications(new Contract<Notification>()
            .Requires()
            .IsGreaterThan(0, Total, "Payment.Total", "O total não pode ser zero")
            .IsGreaterOrEqualsThan(Total, totalPaid, "Payment.TotalPaid", "O valor pago é menor que o valor do pagamento"));
            
        }

        public string Number { get; private set; }
        public DateTime PaidDate { get; private set; }
        public DateTime ExpireDate { get; private set; }
        public decimal Total { get; private set; }
        public decimal totalPaid { get; private set; }
        public int Payer { get; private set; }
        public Document Document { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
    }
 
}