using OpenQA.Selenium;

namespace Automation_Exercise.Pages.CartPage
{
    public partial class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/view_cart";
        public int CalculateTotalPriceForProduct(string productName)
        {
            foreach (var product in productList)
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
           return 0;
        }
        public void RemoveProductFromOrder(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']/p")).Text;
                if (productName == nameOfProduct)
                {
                    product.FindElement(By.XPath("//*[@class='cart_delete']/a")).Click();
                    break;
                }
            }
        }
        public bool CheckProductRemoval(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']/p")).Text;
                if (productName == nameOfProduct)
                {
                    return true;
                }
            }
            return false;
        }
        public void ContinueToCheckout() => proceedToCheckoutButton.Click();
        public void RemoveAllProductFromOrder()
        {
            foreach (var product in productList)
            {
                product.FindElement(By.XPath("//*[@class='cart_delete']/a")).Click();
            }
        }
        public void ContinueToProductPage() => continueToProductPage.Click();
        public void ContinueOnCart() => continueOnCartButton.Click();
        public bool CheckProductIsAddedToCart(string productName)
        {
            foreach (var product in productList)
            {
                string nameOfProduct = product.FindElement(By.XPath("//*[@class='cart_description']//a")).Text;
                if (productName == nameOfProduct)
                {
                    return true;
                }
            }
            return false;
        }
    }
}