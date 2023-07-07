using OpenQA.Selenium;

namespace Automation_Exercise.Pages.ProductDetailsPage;

public partial class ProductDetailsPage : BasePage
{
    public ProductDetailsPage(IWebDriver driver) : base(driver)
    {
       
    }
    public override string PageURL => "https://www.automationexercise.com/product_details/";
    public string GeneratePageDetailsUrl(string productId) => $"https://www.automationexercise.com/product_details/{productId}";
    public void AddProductToCart() => addToCartButton.Click();
    
    public void FillReviewForm(string name , string email , string message)
    {
        nameField.SendKeys(name);
        emailAddressField.SendKeys(email);
        reviewField.SendKeys(message);
    }
    public void SubmitReview() => submitButton.Click();
    public void SetProductQuantity(int quantity)
    {
        productQuantity.Clear();
        productQuantity.SendKeys(quantity.ToString());
    }

}