using OpenQA.Selenium;

namespace Automation_Exercise.Pages.ProductDetailsPage;

public partial class ProductDetailsPage : BasePage
{
    public ProductDetailsPage(IWebDriver driver) : base(driver)
    {
    }
    public override string PageURL => throw new NotImplementedException();//TODO
    public void AddToCartProduct() => addToCartButton.Click();
    
    public void ReviewFormFill(string name , string email , string message)
    {
        nameField.SendKeys(name);
        emailAddressField.SendKeys(email);
        reviewField.SendKeys(message);
    }
    public void SubmitReview() => submitButton.Click();
    //TODO

}