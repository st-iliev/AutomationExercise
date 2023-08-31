# Checkout Page Test Cases

### Test Case 1: Verify Added Product is in Order

Test ID: TC_Order_001

Priority: High

**Description:** 
- Verify that a product added to the cart is displayed correctly in the order.

**Preconditions:**
1. User is login

**Test Data:**

Login credentials:
 - email: "justfortest777@abv.bg"
 - password : "testqa1"

**Test Steps:**
1. Navigate to the product page of the web application.
2. Click on the "Add to Cart" button for the product "Men Tshirt".
3. Click on "View Cart".
4. Click on "Proceed To Checkout" button.

**Expected Results:**
- The product "Men Tshirt" is displayed in the order with the correct product name , quantity , price and total price.


### Test Case 2: Verify Successfully Finished Order

Test ID: TC_Order_002

Priority: High

**Description:** 
- Verify that a user can successfully complete an order.

**Preconditions:**
1. User is login.

**Test Data:**

Login credentials:
- email: "justfortest777@abv.bg"
- password : "testqa1"

**Test Steps:**
1. Navigate to the product page of the web application.
2. Click on the "Add to Cart" button for the product "Sleeveless Dress."
3. Click on "View Cart".
4. Click on "Proceed To Checkout" button.
5. Fill commect textarea with "Test".
5. Click on "Place Order".

**Expected Results:**
- The user is redirected to payment page.

### Test Case 3: Verify Information about Delivery and Billing Addresses

Test ID: TC_Checkout_001

Priority: High

**Description:** 
- Verify that the information about the delivery and billing addresses is displayed correctly.

**Preconditions:**
1. User is login.

**Test Data:**

Login credentials:
- email: "justfortest777@abv.bg"
- password : "testqa1"
User information:
title : "Mrs"
firstName : "Matthew"
lastName : "Tudor"
firstAddress : "Yalta str"
secondAddress : "Bulgaria bul"
companyName : "Space Z"
state : "Sula"
city : "Hamilton"
country : "Australia"
zipCode : "64834"
mobileNumber : "(492) 957-325"

**Test Steps:**
1. Navigate to the product page of the web application.
2. Click on the "Add to Cart" button for the product "Blue Top."
3. Click on "View Cart".
4. Click on "Proceed To Checkout" button.

**Expected Results:**
- The billing address information and delivery address information are displayed correctly and match the user's information.


### Test Case 4: Verify Home Button Redirection.

Test ID: TC_HomeButton_001

Priority: Low

**Description:** 
- Verify that the home button on the checkout page redirects the user to the home page.

**Preconditions:**
1. User is login.

**Test Data:**

Login credentials:
- email: "justfortest777@abv.bg"
- password : "testqa1"

**Test Steps:**
1. Navigate to the checkout page of the web application.
2. Click on the "Home" button.

**Expected Results:**
- The user is successfully redirected to home page.

## Test Case 5: Verify Scroll Down Functionality

Test ID: TC_ScrollDown_001

Priority: Medium

**Description:** 
- Verify that the scroll-down functionality of a webpage works correctly.

**Preconditions:**
1. User is login.

**Test Data:**

Login credentials:
- email: "justfortest777@abv.bg"
- password : "testqa1"

**Test Steps:**
1. Navigate to the checkout page of the web application.
2. Scroll down to bottom of page.


**Expected Results:**
- Text of copyright "Copyright © 2021 All rights reserved" is displayed.

### Test Case 6: Verify Functionality of Scroll-Up Button

Test ID: TC_ScrollUpButton_001

Priority: Medium

**Description:** 
- Verify that the scroll-up button on the webpage functions correctly.

**Preconditions:**
1. User is login.

**Test Data:**

Login credentials:
- email: "justfortest777@abv.bg"
- password : "testqa1"

Height of scroll down in pixels:
1250, 2980, 4550, 6310

**Test Steps:**
1. Navigate to the checkout page of the web application.
2. Scroll down the webpage by the test data height.
3. Click on "Scroll-up" button.

**Expected Results:**
- The website logo is displayed on top of the page.
