# PaymentDone Page Test Cases

### Test Case 1: Verify Download and Check Content of Invoice File

Test ID: TC_Download_Invoice_001

Priority: High

**Description:** 
- This test verifies the download and content of an invoice file after a successful payment.

**Preconditions:**
1. The user is logged in.
2. The user has added a "Blue Top" product to the cart and completed a successful payment.
3. Open payment page.

**Test Data:**
 - NameOnCard : "Matthew Tudor"
 - CardNumber : "7271 9888 3445 9541"
 - CVC : "672"
 - ExpirationMonth : "09"
 - ExpirationYear : "29"

**Test Steps:**
1. Fill Payment form with valid data values.
2. Click on "Pay and Confirm Order" button.
3. Click on "Download Invoice" button.
4. Click on "Continue" button.

**Expected Results:**
- The invoice file is downloaded successfully and  content of the downloaded invoice file matches the expected content "Hi Matthew Tudor, Your total purchase amount is 500. Thank you.".The user is redirected to home page.

### Test Case 2: Verify Complete Order Without Added Product

Test ID: TC_Complete_Order_No_Product_001

Priority: High

**Description:** 
- This test verifies that a user cannot complete an order without adding any products to the cart.

**Preconditions:**
1. The user is logged in.
2. Open payment page.

**Test Data:**
 - NameOnCard : "Matthew Tudor"
 - CardNumber : "7271 9888 3445 9541"
 - CVC : "672"
 - ExpirationMonth : "09"
 - ExpirationYear : "29"

**Test Steps:**
1. Fill Payment form with valid data values.
2. Click on "Pay and Confirm Order" button.
3. Click on "Download Invoice" button.
4. Click on "Continue" button.

**Expected Results:**
- The invoice file is downloaded successfully and  content of the downloaded invoice file matches the expected content "Hi Matthew Tudor, Your total purchase amount is 0. Thank you.".The user is redirected to home page.

### Test Case 3: Verify Successful Subscription from paymentdone page.

Test ID: TC_Subscribe_Success_001

Priority: High

**Description:** 
- This test verifies that a user can successfully subscribe to the website using valid credentials.

**Preconditions:**
1. Open payment page.
2. Fill payment form with valid data values.
3. Click on "Pay and Confirm Order" button.

**Test Data:**

**Test Steps:**
1. Scroll to the bottom of the page.
2. Fill email field with "justfortest777@abv.bg".
2. Click on "Subscribe" butoon.

**Expected Results:**
- The successfull message "You have been successfully subscribed!" is displayed.

### Test Case 4: Verify Subscription with Invalid Credentials from paymentdone page.

Test ID: TC_Subscribe_InvalidCredentials_001

Priority: High

**Description:** 
- This test verifies that the subscription process rejects invalid credentials and displays appropriate error messages.

**Preconditions:**
1. Open payment page.
2. Fill payment form with valid data values.
3. Click on "Pay and Confirm Order" button.

**Test Data:**

Email Scenarios:
 - email : ""
 - email : "invalidEmail"
 - email : "invalidEmail@"

**Test Steps:**
1. Scroll to the bottom of the page.
2. Fill email field with test data.
2. Click on "Subscribe" butoon.

**Expected Results:**
- The appropriate error messages are displayed:
  - When email field is empty , an error message "Please fill out this field." is displayed.
  - When email field is field with "invalidEmail" , an error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
  - When email field is field with "invalidEmail@" , an error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.
