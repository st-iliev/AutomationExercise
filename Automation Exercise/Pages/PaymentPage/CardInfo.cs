using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.PaymentPage
{
    public class CardInfo
    {
        public CardInfo()
        {
            NameOnCard = $"{Constants.firstName} {Constants.lastName}";
            CardNumber = Constants.cardNumber;
            CVC = Constants.CVC;
            ExpirationMonth = Constants.expirationMonth;
            ExpirationYear = Constants.expirationYear;
        }
        public string NameOnCard { get; set; }
        public string CardNumber { get; set; }
        public string CVC { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set;}

    }
}
