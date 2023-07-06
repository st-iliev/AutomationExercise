using OpenQA.Selenium;

namespace Automation_Exercise.Pages.CheckoutPage
{
    public partial class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }
        public override string PageURL => "https://www.automationexercise.com/checkout";
        public int CalculateTotalPriceForProduct(string productName)
        {
            foreach (var product in orderProducts)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']/p")).Text;
                if (productName == nameOfProduct)
                {
                    int productPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_price']/p")).Text.Split(" ")[1]);
                    int productQuantity = int.Parse(product.FindElement(By.XPath("//button[@class='disable']")).Text);
                    int productTotalPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_total']/p")).Text.Split(" ")[1]);
                    if (productPrice * productQuantity == productTotalPrice)
                    {
                        return productPrice;
                    }
                }
            }
            return "Product name doesn't exist";
        }
        public int CalculateTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in orderProducts)
            {
                int productTotalPrice = int.Parse(product.FindElement(By.XPath("//*[@class='cart_total']/p")).Text.Split(" ")[1]);
                totalPrice += productTotalPrice;
            }
            return totalPrice;
        }

        public int TotalOrderAmount() => int.Parse(cartTotalPrice.Text.Split(" ")[1]);
    }
}
