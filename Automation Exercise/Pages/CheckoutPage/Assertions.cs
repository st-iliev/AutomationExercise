using Automation_Exercise.Utilities;

namespace Automation_Exercise.Pages.CheckoutPage
{
    partial class CheckoutPage
    {
        public void AssertCorrectPageIsLoaded()
        {
            Assert.AreEqual("Automation Exercise - Checkout", GetPageTitle());
        }
        public void AssertAddressesDetailsFormTitleIsDisplayedCorectly()
        {
            Assert.AreEqual("Address Details", addressFormTitle.Text);
        }
        public void AssertDeliveryAddressFormIsFilledCorrectly()
        {
            
            Assert.AreEqual("Your delivery address", deliveryAddress.Text);  
            Assert.AreEqual($". {Constants.firstName} {Constants.lastName}", deliveryFirstLastNameInfo.Text);
            Assert.AreEqual(Constants.companyName, deliveryCompanyInfo.Text);
            Assert.AreEqual(Constants.firstAddress, deliveryAddress1Info.Text);
            Assert.AreEqual(Constants.secondAddress, deliveryAddress2Info.Text);
            Assert.AreEqual($"{Constants.city} {Constants.state} {Constants.zipCode}", deliveryCityNameStateZipCode.Text);
            Assert.AreEqual(Constants.country, deliveryCountryInfo.Text);
            Assert.AreEqual(Constants.mobileNumber, deliveryPhoneNumberInfo.Text);
        }
        public void AssertBillingAddressFormIsFilledCorrectly()
        {
            Assert.AreEqual("Your billing address", billingAddress.Text);
            Assert.AreEqual($". {Constants.firstName} {Constants.lastName}", billingFirstLastNameInfo.Text);
            Assert.AreEqual(Constants.companyName, billingCompanyInfo.Text);
            Assert.AreEqual(Constants.firstAddress, billingAddress1Info.Text);
            Assert.AreEqual(Constants.secondAddress, billingAddress2Info.Text);
            Assert.AreEqual($"{Constants.city} {Constants.state} {Constants.zipCode}", billingCityNameStateZipCode.Text);
            Assert.AreEqual(Constants.country, billingCountryInfo.Text);
            Assert.AreEqual(Constants.mobileNumber, billingPhoneNumberInfo.Text);
        }
        public void AssertCorrectTotalPriceOfProductIsCalculation(int expectedAmount, string productName)
        {
            Assert.AreEqual(expectedAmount, CalculateTotalPriceForProduct(productName));
        }
        public void AssertCorrectTotalPriceOfOrderIsCalculation(int expectedAmount)
        {
            Assert.AreEqual(expectedAmount, TotalPriceCalculation());
            Assert.AreEqual(expectedAmount, OrderTotalAmount());
        }
        public void AssertProductListIsNotEmpty()
        {
            Assert.Greater(orderProducts.Count, 0);
        }
        public void AssertProductIsInOrder(string productName)
        {
            Assert.True(CheckIfProductIsAdded(productName));
        }
    }
}
