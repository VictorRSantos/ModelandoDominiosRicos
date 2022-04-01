
namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderNamer, string cardNumber, string lastTransactionNumber, DateTime paiDate, DateTime expireDate, decimal total, decimal totalPaid, string owner, string document, string address, string email)
         : base(paiDate, expireDate, total, totalPaid, owner, document, address, email)
        {
            CardHolderNamer = cardHolderNamer;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderNamer { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }

    }
}