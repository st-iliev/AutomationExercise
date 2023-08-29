# Login Page Test Cases

**Test Case 1:** Verify Successful Subscription from Login Page.

Test ID: TC_Subscription_001

Priority: Medium

**Description:** 
- Verify that a user can successfully subscribe from the login page.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Scroll to the bottom of the login page.
2. Fill email field with "justfortest777@abv.bg".
3. Click on the "Subscribe" button.

**Test Data:**

**Expected Results:**
- The  successful subscription message "You have been successfully subscribed!" is displayed.

**Test Case 2:** Verify Subscribe with Invalid Email from Login Page.

Test ID: TC_Subscription_002

Priority: Medium

**Description:** 
- Verify that appropriate error messages are displayed when a user tries to subscribe using invalid email addresses from the login page.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Scroll to the bottom of the login page.
2. Fill email field with invalid credential based on test data.
3. Click on the "Subscribe" button.

**Test Data:**
Email: null
Email: "invalidEmail"
Email: "invalidEmail@"

**Expected Results:**
- The correct error messages are displayed based on the entered email:
  - When email is null: An error message "Please fill out this field." is displayed.
  -  When email is "invalidEmail": An error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
  - When email is "invalidEmail@": An error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.


**Test Case 3:** Verify User Login Without Credentials.

Test ID: TC_Login_003

Priority: Medium

**Description:** 
- Verify that appropriate error messages are displayed when a user tries to log in without providing email or password.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Fill email field with data values.
2. Fill password field with data values.
3. Click on the "Login" button.

**Test Data:**

Scenarios:

email: "justfortest777@abv.bg" , password : ""

email: "" , password : "testqa1"

email: "" , password : ""

**Expected Results:**
- An error message "Please fill out this field." is displayed on empty fields.

**Test Case 4:** Verify User Login With Invalid Credentials.

Test ID: TC_Login_004

Priority: Medium

**Description:** 
- Verify that appropriate error messages are displayed when a user tries to log in with an invalid email or password.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Fill email field with data values.
2. Fill password field with data values.
3. Click on the "Login" button. 

**Test Data:**

Scenarios:

email: "justfortest777@abv.bg" , password : "qatest"

email: "incorrectEmail" , password : "testqa1"

email: "incorrectEmail@" , password : "testqa1"


**Expected Results:**
- The correct error messages are displayed based on the entered values:
   - When email is"justfortest777@abv.bg" and password is "qatest": An error message "Your email or password is incorrect!" is displayed.
   -  When email is"incorrectEmail" and password is "testqa1": An error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
   - When email  is "incorrectEmail@" and password is "testqa1": An error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.

**Test Case 5:** Verify User Signup Without Credentials

Test ID: TC_Signup_003

Priority: Medium

**Description:** 
- Verify that appropriate error messages are displayed when a user tries to sign up without providing a name or email.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Fill name field with data values.
2. Fill email field with data values.
3. Click on the "Sign Up" button.

**Test Data:**

Scenarios:

name: "Mat" , email : ""

name: "" , email : "justfortest777@abv.bg"

name: "" , email : ""

**Expected Results:**
-  An error message "Please fill out this field." is displayed on empty field.

**Test Case 6:**  Verify Scroll Down Functionality

Test ID: TC_Scroll_001

Priority: Low

**Description:** 
- Verify that the scroll-down functionality of the page works as expected and that the footer's copyright text is displayed..

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Scroll down to the bottom of the page.

**Test Data:**

**Expected Results:**
- The  copyright text in the footer is displayed.

**Test Case 7:** Verify Scroll Up Button Functionality

Test ID: TC_Scroll_002

Priority: Low

**Description:** 
- Verify that the scroll-up button functionality of the page works.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Scroll down to the bottom of the page.
2. Click on "scrollup" button.

**Test Data:**

**Expected Results:**
- The website logo is displayed no the top of the page.

**Test Case 8:** Verify User Login with Valid Credentials

Test ID: TC_Login_001

Priority: High

**Description:** 
- Verify that a user can successfully log in using valid email and password credentials.

**Preconditions:**
1. Open login page.

**Test Steps:**
1. Fill email field with "justfortest777@abv.bg".
2. Fill password field with "testqa1".
3. Click on the "Login" button.
   
**Test Data:**

**Expected Results:**
- Use is redirected to home page and the user is logged in.
