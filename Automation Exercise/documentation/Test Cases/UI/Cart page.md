# Cart Page Test Cases

**Test Case 1:** Verify User Cart is Empty Without Login.

Test ID: TC_Cart_001

Priority: High  

**Description:** 
- Verify that the cart of a non-logged-in user is empty, and the appropriate message is displayed.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.

**Test Steps:**
1. Open the homepage of the web application.
2. Click on "Cart" link on header navigation bar.

**Expected Results:**
- The correct cart page is loaded and empty cart message "Cart is empty! Click here to buy products." is displayed.

**Test Case 2:** Verify Non-Logged-In User Can Add Product to Cart

Test ID: TC_Auto_Cart_002

Priority: High

**Description:** 
- Verify that a non-logged-in user can successfully add a product to their cart, and the product is correctly displayed in the cart.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.
3. User cart is empty.

**Test Steps:**
1. Open product page.
2. Scroll down on the product page.
3. Click on "Add to cart" on "Blue Top" product.
4. Open the cart page.

**Expected Results:**
- The product added successful message "Your product has been added to cart." is displayed.The "Blue Top" product is added to the cart.


**Test Case 3:** Verify Non-Logged-In User Can't Checkout

Test ID: TC_Checkout_001

Priority: High

**Description:** 
- Verify that a non-logged-in user cannot proceed to checkout and is prompted to log in.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see "Blue Top" product.
3. Click on "Add to cart" on "Blue Top" product.
4. Click on "View Cart".
5. Click on "Proceed To Checkout" button.

**Expected Results:**
- The checkout process is interrupted, and a message "Register / Login account to proceed on checkout." is displayed.


**Test Case 4:** Verify Total Price of All Added Products Are Correct Without Login.

Test ID: TC_Cart_003

Priority: High

**Description:** 
- Verify that the total price of all added products in the cart is correct for a non-logged-in user.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see "Men Tshirt" product.
3. Click on "Add to cart" on "Men Tshirt" product.
4. Click on "Continue shopping" button.
5. Click on "Add to cart" on "Blue Top" product.
6. Continue shopping.
7. Click on "Add to cart" on "Sleeveless Dress" product.
8. Click on "View Cart".

**Expected Results:**
- The all added products are in cart and  total price of each added product in the cart is correct.

**Test Case 5:** Verify Non-Logged-In User Can Remove Product from Cart.

Test ID: TC_Cart_004

Priority: High

**Description:** 
- Verify that a non-logged-in user can successfully remove a product from their cart.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.

**Test Steps:**
1. Open the cart page.
2. Open the product page.
3. Scroll down on the product page until see "Blue Top" product.
4. Click on "Add to cart" on "Blue Top" product.
5. Click on "View Cart".
6. Click on "cross" on right side of "Blue Top" product row.

**Expected Results:**
- The "Blue Top" product is successfully removed from the cart.

**Test Case 6:** Verify Non-Logged-In User Can Remove All Products from Cart

Test ID: TC_Cart_005

Priority: High

**Description:** 
- Verify that a non-logged-in user can successfully remove all products from their cart.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.
3. Add products to cart page.

**Test Steps:**
1. Open the cart page.
2. Click on "cross" on right side of each product row.

**Expected Results:**
- The products are successfully removed from the cart and empty cart message "Cart is empty! Click here to buy products." is displayed.

**Test Case 7:** Verify Non-Logged-In User Is Redirected to Home Page.

Test ID: TC_Cart_006

Priority: High

**Description:** 
- Verify that a non-logged-in user is redirected to the home page using the home button.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged out.

**Test Steps:**
1. Open the cart page.
2. Click on "Home Button" on top left side.

**Expected Results:**
- User is redirected to home page.

**Test Case 8:** Verify Logged-In User's Cart Is Empty

Test ID: TC_Cart_007

Priority: High

**Description:** 
- Verify that the cart of a logged-in user is empty when they access it.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.
3. User cart is empty.

**Test Steps:**
1. Open the cart page.

**Expected Results:**
- The cart is empty, and the correct empty cart message "Cart is empty! Click here to buy products." is displayed.


**Test Case 9:** Verify Logged-In User Can Add Product to Cart

Test ID: TC_Cart_008

Priority: High

**Description:** 
- Verify that a logged-in user can successfully add a product to their cart.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see 'Blue Top" product.
3. Click on "Add to cart" on "Blue Top" product.
4. Click on "View cart" link.

**Expected Results:**
- The correct cart page is loaded and "Blue Top" product is successfully added to the cart.


**Test Case 10:** Verify Logged-In User Can Proceed to Checkout

Test ID: TC_Cart_009

Priority: High

**Description:** 
- Verify that a logged-in user can successfully proceed to the checkout process.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see 'Blue Top" product.
3. Click on "Add to cart" on "Blue Top" product.
4. Click on "View cart" link.
5. Click on "Proceed TO Checkout" button.

**Expected Results:**
- User is redirected to correct checkout page and addresses details is loaded.

**Test Case 11:** Verify Logged-In User's Total Price of Added Product Is Correct.

Test ID: TC_Cart_010

Priority: High

**Description:** 
- Verify that the total price of the added product is correct for a logged-in user.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see 'Blue Top" product.
3. Click on "Add to cart" on "Blue Top" product.
4. Click on "View cart" link.

**Expected Results:**
- The correct cart page is loaded and  total price of the "Blue Top" product is correct.

**Test Case 12:** Verify Logged-In User Can Remove Product from Cart.

Test ID: TC_Cart_011

Priority: High

**Description:** 
- Verify that a logged-in user can successfully remove a product from their cart.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see 'Blue Top" product.
3. Click on "Add to cart" on "Blue Top" product.
4. Click on "View cart" link.
5. Click on "cross" on right side of "Blue Top" product row.

**Expected Results:**
- The correct cart page is loaded and "Blue Top" product is successfully removed from the cart.

**Test Case 13:** Verify Logged-In User's Total Price of All Added Products Is Correct.

Test ID: TC_Cart_012

Priority: High

**Description:** 
- Verify that the total price of all added products is correct for a logged-in user.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.

**Test Steps:**
1. Open the product page.
2. Scroll down on the product page until see "Men Tshirt" product.
3. Click on "Add to cart" on "Men Tshirt" product.
4. Click on "Continue Shopping" button.
5. Click on "Add to cart" on "Blue Top" product.
6. Click on "Continue Shopping" button.
5. Click on "Add to cart" on "Sleeveless Dress" product.
6. Click on "View Cart" link.

**Expected Results:**
- The correct cart page is loaded and total price of all added products is correct.

**Test Case 14:** Verify Logged-In User Can Remove All Products from Cart.

Test ID: TC_Cart_013

Priority: High

**Description:** 
- Verify that a logged-in user can successfully remove all products from their cart.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is logged in.
3. Products are added to the cart.

**Test Steps:**
1. Open the cart page.
2. Clicking on "cross" on right side of each product row.

**Expected Results:**
- The cart is empty, and the correct empty cart message "Cart is empty! Click here to buy products." is displayed.


**Test Case 15:** Verify Scroll Down Functionality.

Test ID: TC_General_001

Priority: Medium

**Description:** 
- Verify that the scroll down functionality of the page works as expected.

**Preconditions:** 

**Test Steps:**
1. Open the cart page.
2. Scroll down to the bottom of the page.

**Expected Results:**
- The copyright text is displayed to the bottom of the page.

**Test Case 16:** Verify Scroll Up Button Functionality.

Test ID: TC_General_002

Priority: Medium

**Description:** 
- Verify that the scroll up button functionality of the page works as expected.

**Preconditions:**

**Test Steps:**
1. Open the cart page.
2. Scroll to the bottom of the page.
3. Click on "scrollup button".

**Expected Results:**
-  The website logo is displayed.

**Test Case 17:** Verify Home Button Redirection to Home Page.

Test ID: TC_General_003

Priority: High

**Description:** 
- Verify that the home button correctly redirects the user to the home page.

**Preconditions:**

**Test Steps:**
1. Open the cart page.
2. Click on the "Home" button.

**Expected Results:**
- User is correctly redirected to  home page and carousel texts are displayed.
