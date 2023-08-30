# ProductDetails Page Test Cases

**Test Case 1:** Verify Successful Subscription.

Test ID: TC_Subscribe_001

Priority: High

**Description:** 
- Verify that a user can successfully subscribe to the website using valid email credentials from the product details page.

**Preconditions:**
1. Open home page of web application.

**Test Data:**

**Test Steps:**
1. Click on "View Product" on "Blue Top" product.
2. Scroll down to bottom of page.
3. Fill email field with "justfortest777@abv.bg"
4. Click on the "Subscribe" button.

**Expected Results:**
-  The successfull message "You have been successfully subscribed!" is displayed.

**Test Case 2:** Verify Subscribe With Invalid Email From Product Details Page

Test ID: TC_Subscribe_002

Priority: High

**Description:** 
- Verify that the subscription process handles invalid email credentials correctly when subscribing from the product details page.

**Preconditions:**
1. Open home page of web application.

**Test Data:**

Email Cases:
 - email : 	empty
 - email : invalidEmail
 - email :invalidEmail@

**Test Steps:**
1. Click on "View Product"  for the product named "Blue Top".
2. Scroll down to bottom of page.
3. Fill email field with test data values.
4. Click on the "Subscribe" button.

**Expected Results:**
-  For each case of invalid email credentials:
    - When email field is fieled with empty, an error message "Please fill out this field." is displayed.
    - When email field is fieled with"invalidEmail", an error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
    - When email field is fieled with "invalidEmail@", an error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.

**Test Case 3:** Verify Product Details Are Correct

Test ID: TC_ProductDetails_001

Priority: High

**Description:** 
- Verify that the product details are displayed correctly on the product details page.

**Preconditions:**
1. Open home page of web application.

**Test Data:**

**Test Steps:**
1. Click on the "View Product"  for the product named "Stylish Dress."

**Expected Results:**
-  The product details page displays the correct product information:
name = "Stylish Dress", price = "1500", brand = "Madame", condition = "New" ,availability status = "In Stock"

**Test Case 4:** Verify Submitting Review for Product With Valid Data

Test ID: TC_ProductReview_001

Priority: High

**Description:** 
- Verify that a user can successfully submit a review for a product with valid credentials.

**Preconditions:**
1. Open home page of web application.

**Test Data:**

**Test Steps:**
1. Click on the "View Product"  for the product named "Blue Top."
2. Fill in the review form with the following valid data :
 - Name: "Matthew"
 - Email: "justfortest777@abv.bg"
 - Review Text: "I highly recommend this product to anyone in need. It's a valuable addition to any setup. Thank you for creating such a fantastic product!"
3. Click on "Submit" button.

**Expected Results:**
-  The successfull message "Thank you for your review." is displayed.

**Test Case 5:** Verify Submitting Review for Product With Invalid Data.

Test ID: TC_ProductReview_002

Priority: High

**Description:** 
- Users are unable to submit reviews containing invalid or incomplete data for a product.

**Preconditions:**
1. Open home page of web application.

**Test Data:**
- Cases:
name : "", email : "", reviewText : ""
name : "Jordan", email : "", reviewText : ""
name : "George", email : "email", reviewText : ""
name : "John", email : "email@", reviewText : ""
name : "John", email : "email@zzz", reviewText : ""

**Test Steps:**
1. Click on the "View Product" for the product named "Blue Top."
2. Filled the review form with the following test data inputs:
3. Click on "Submit" button.

**Expected Results:**
-  Based on the input data provided:
    - When  name field is left empty, an error message "Please fill out this field." is displayed.
    - When  email field is left empty, an error message "Please fill out this field." is displayed.
     - When email field is fill with "email" , an error message "Please include an '@' in the email address. 'email' is missing an '@'." is displayed.
     - When email field is fill with "email@" , an error message "Please enter a part following '@'. 'email@' is incomplete." is displayed.
     - When review field is empty , an erro message "Please fill out this field." is displayed.


**Test Case 6:** Verify Successful Addition of Product to Cart from Product Details Page

Test ID: TC_AddProduct_001

Priority: High

**Description:** 
- This test validates the successful addition of a product to the cart from the product details page.

**Preconditions:**
1. Open home page of web application.

**Test Data:**

**Test Steps:**
1. Click on the "View Product" for the product named "Sleeveless Dress"
2. Click on "Add to cart" button.
3. Click on "View Cart" link.

**Expected Results:**
-  The selected product "Sleeveless Dress" is successfully added to the cart. 


### Test Case 7: Verify Changing Quantity and Adding Product from Product Details Page

**Description:** 
- This test validates the functionality of changing the quantity of a product and adding it to the cart from the product details page. 

**Preconditions:**
1. Open home page of web application.

**Test Data:**

**Test Steps:**
1. Click on the "View Product" for the product named "Blue Top".
2. Fill quality field with "3".
3. Click on "Add to cart" button.
4. Click on "View Cart" link.

**Expected Results:**
-  The product "Blue Top" is added to cart with quantity of 3.

