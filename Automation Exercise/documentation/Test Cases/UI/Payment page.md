# Payment Page Test Cases

### Test Case 1: Verify Successful Payment with Valid Data

Test ID: TC_Payment_001

Priority: High

**Description:** 
- This test ensures that user can successfully make a payment using valid payment information on the payment page.

**Preconditions:**
1. User is login.
2. Open payment page of web application.

**Test Data:**
 - NameOnCard : "Matthew Tudor"
 - CardNumber : "7271 9888 3445 9541"
 - CVC : "672"
 - ExpirationMonth : "09"
 - ExpirationYear : "29"

**Test Steps:**
1. Fill Payment form with valid data values.
2. Click on "Pay and Confirm Order" button.

**Expected Results:**
- The successfull message "Congratulations! Your order has been confirmed!" is displayed and user is redirected to paymentdone page.

### Test Case 2: Verify Payment Form Validation for Empty Fields

Test ID: TC_Payment_002

Priority: Medium

**Description:** 
- This test ensures that the payment form displays appropriate validation messages when the user attempts to submit the form with empty fields.

**Preconditions:**
1. User is login.
2. Open payment page of web application.

**Test Data:**

Scenatios:
- name : "" , cardNumber : "", cvc : "" , expirationMonth : "" , expirationYear: ""
- name : "Matthew Tudor" , cardNumber : "7271 9888 3445 9541", cvc : "" , expirationMonth : "" , expirationYear: ""
- name : "Matthew Tudor" , cardNumber : "7271 9888 3445 9541", cvc : "672" , expirationMonth : "" , expirationYear: ""
- name : "Matthew Tudor" , cardNumber : "7271 9888 3445 9541", cvc : "672" , expirationMonth : "09" , expirationYear: ""
- name : "Matthew Tudor" , cardNumber : "7271 9888 3445 9541", cvc : "672" , expirationMonth : "09" , expirationYear: ""„
  
**Test Steps:**
1. Fill Payment form with the following information:
2. Click on the "Pay and Confirm Order" button.

**Expected Results:**
- For each empty field in the payment form user should see an appropriate validation message ""Please fill out this field.".

### Test Case 3: Verify Successful Subscription from payment page.

Test ID: TC_Payment_003

Priority: High

**Description:** 
- This test verifies that users can successfully subscribe to receive updates using valid email credentials.

**Preconditions:**
1. User is login.
2. Open payment page of web application.

**Test Data:**

**Test Steps:**
1. Scroll down to the bottom of the payment page.
2. Fill email address field with  "justfortest777@abv.bg".
3. Click on the "Subscribe" button.

**Expected Results:**
- The successfull message "You have been successfully subscribed!" is displayed.

### Test Case 4:  Verify Subscription with Invalid Email from payment page.

Test ID: TC_Payment_004

Priority: Medium

**Description:** 
- This test verifies that users cannot subscribe using invalid email credentials.

**Preconditions:**
1. User is login.
2. Open payment page of web application.

**Test Data:**
Email Cases:
 - email : ""
 - email : "invalidEmail"
 - email : "invalidEmail@"

**Test Steps:**
1. Scroll down to the bottom of the payment page.
2. Fill email address field with test data.
3. Click on the "Subscribe" button.


**Expected Results:**
- Depending on the provided invalid email address:
  - When email field is empty, an error message "Please fill out this field." is displayed.
  - When email field is filled with "invalidEmail", an error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
  - When email field is filled with "invalidEmail@", an error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.

### Test Case 5:Verify Home Button Redirection

Test ID: TC_Payment_005

Priority: High

**Description:** 
- This test verifies that the "Home" button correctly redirects the user to the home page.

**Preconditions:**
1. User is login.
2. Open payment page of web application.

**Test Data:**

**Test Steps:**
1. Click on the "Home" button on top left corner of page.

**Expected Results:**
- The user is redirected to the home page.
