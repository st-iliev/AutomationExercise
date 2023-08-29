# Signup Page Test Cases

**Test Case 1:** Verify Successful Subscription.

Test ID: TC_Subscribe_001

Priority: High

**Description:** 
- Verify that a user can successfully subscribe to the website using valid credentials.

**Preconditions:**
1. Open login page.
2. Signup with valid credentials.
 - Fill name field with "Mat"
 - Fill email field with "justfortest777@abv.bg".
3. Click on "Signup" button.

**Test Steps:**
1. Scroll to the bottom of the page.
2. Enter a valid email address in the subscription field.
3. Click on the "Subscribe" button.

**Test Data:**
 - email : "justfortest777@abv.bg"

**Expected Results:**
- The correct successful subscription message "You have been successfully subscribed!" is displayed.

**Test Case 2:** Verify Subscription with Invalid Credentials.

Test ID: TC_Subscribe_002

Priority: High

**Description:** 
- Verify that a user cannot subscribe to the website using invalid email credentials.

**Preconditions:**
1. Open login page.
2. Signup with valid credentials.
 - Fill name field with "Mat"
 - Fill email field with "justfortest777@abv.bg".
3. Click on "Signup" button.

**Test Steps:**
1. Scroll to the bottom of the page.
2. Enter an invalid email address in the subscription field.
3. Click on the "Subscribe" button.

**Test Data:**

Email Scenarios:
  - email : ""
  - email : "invalidEmail"
  - email : "invalidEmail@"

**Expected Results:**
- The different error messages displayed depend of input data:
    When the email field is empty (""): An error message "Please fill out this field." is displayed.
    When the email is "invalidEmail": An error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
    When the email is "invalidEmail@": An error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.

**Test Case 3:** Verify Registration of New User Filled Only Required Fields.

Test ID: TC_Register_001

Priority: High

**Description:** 
- Verify that a new user can register using only the required fields, and the account is successfully created.

**Preconditions:**
1. Open login page.
2. Signup with valid credentials.
 - Fill name field with "Mat"
 - Fill email field with "justfortest777@abv.bg".
3. Click on "Signup" button.

**Test Steps:**
1. Fill in the signup form with the following required account information.
2. Click on the "Create Account" button.
3. Click on "Continue" button.

**Test Data:**
Account information:
  - title = "Mr"
  - name = "Mat"
  - password = "testqa1"
  - firstName = "Matthew"
  - lastName = "Tudor"
  - companyName = "Space Z"
  - firstAddress = "Yalta str"
  - country = "Australia"
  - state = "Sula"
  - city = "Hamilton"
  - zipCode = "64834"
  - mobileNumber = "(492) 957-325"

**Expected Results:**
- The user is redirected to the homepage after account creation.

**Test Case 4:**  Verify Error Message Displayed on Required Fields.

Test ID: TC_Validation_001

Priority: Medium

**Description:** 
- Verify that error messages are displayed for each required field if they are left empty during user registration.

**Preconditions:**
1. Open login page.
2. Signup with valid credentials.
 - Fill name field with "Mat"
 - Fill email field with "justfortest777@abv.bg".
3. Click on "Signup" button.

**Test Steps:**
1. Left name field empty.
2. Click on the "Create Account" button.
3. Fill name field with "Mat".
4. Left password field empty.
5. Click on the "Create Account" button.
6. Fill password field with "testqa1".
7. Left firstname field empty.
8. Click on the "Create Account" button.
9. Fill firstname field with "Matthew".
10. Left lastname field empty.
11. Click on the "Create Account" button.
12. Fill lastname field with Tudor".
13. Left firstAddress field empty.
14. Click on the "Create Account" button.
15. Fill firstAddress field with "Yalta str"
16. Left state field empty.
17. Click on the "Create Account" button.
18. Fill state field with "Sula".
19. Left city field empty.
20. Click on the "Create Account" button.
21. Fill city field with "Hamilton".
22. Left zipCode field empty.
23. Click on the "Create Account" button.
24. Fill zipCOde field with "64834".
25. Left mobileNumber field empty.
26. Click on the "Create Account" button.

**Test Data:**
Account information:
  - name = "Mat"
  - password = "testqa1"
  - firstName = "Matthew"
  - lastName = "Tudor"
  - companyName = "Space Z"
  - firstAddress = "Yalta str"
  - state = "Sula"
  - city = "Hamilton"
  - zipCode = "64834"
  - mobileNumber = "(492) 957-325"

**Expected Results:**
- The message for empty field "Please fill out this field." is displayed everytime when requred field left empty.

**Test Case 5:** Verify Registration of New User with All Credentials

Test ID: TC_Registration_001

Priority: High

**Description:** 
- Verify that a new user can successfully register an account with all required and optional credentials.

**Preconditions:**
1. Open login page.
2. Fill name field with "Mat"
3. Fill email field with "justfortest777@abv.bg".
4. Click on "Signup" button.

**Test Steps:**
1. Fill in the signup form with the provided values for each required and optional field.
2. Click on the "Create Account" button.
3. Click on the "Continue" button.

**Test Data:**
 - title = "Mr"
 - name = "Mat"
 - username = "testqa1"
 - password = "testqa1"
 - dayOfMonth = "22"
 - monthOfYear = "July"
 - years = "1999"
 - firstName = "Matthew"
 - lastName = "Tudor"
 - email = "justfortest777@abv.bg"
 - firstAddress = "Yalta str"
 - secondAddress = "Bulgaria bul"
 - companyName = "Space Z"
 - state = "Sula"
 - city = "Hamilton"
 - country = "Australia"
 - zipCode = "64834"
 - mobileNumber = "(492) 957-325"

**Expected Results:**
- The home page is loaded and the user is logged in.

