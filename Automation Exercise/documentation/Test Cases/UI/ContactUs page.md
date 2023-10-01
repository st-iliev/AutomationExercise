# ContactUs Page Test Cases

**Test Case 1:** Verify Submitting Contact Form with Invalid Email Address

Test ID: TC_Contact_001

Priority: Medium

**Description:** 
- Verify that the contact form cannot be submitted with invalid email addresses, and appropriate error messages are displayed.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the Contact Us page.

**Test Steps:**
1. Provide an invalid email address as test data.
2. Fill out the Contact Us form with valid credentials based on the test data.
3. Submit the Contact Us form.

**Test Data:**

Name: "Mat"

Subject:"Field validations."

Message:"Dear [Site Support Team/Technical Support Team],I hope this email finds you well. 
I am writing to request the addition of validation on an important field within the [https://www.automationexercise.com/]. 
This enhancement will help ensure data accuracy, integrity, and provide a better user experience for all users."

Email Scenarios:
 - email: null
 - email: "invalidEmail"
 - email: "InvalidEmail@"

**Expected Results:**
- Error messages based on the provided email value are displayed:
  - When email = null.The error message "Please fill out this field." is displayed.
  - When email = invalidEmail.The error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
  - When email = InvalidEmail@.The error message "Please enter a part following '@'. 'InvalidEmail@' is incomplete." is displayed.

**Test Case 2:** Verify Submitting Contact Form with Valid Data

Test ID: TC_Contact_002

Priority: High

**Description:** 
- Verify that the contact form can be successfully submitted with valid credentials.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the Contact Us page.

**Test Steps:**
1. Open the Contact Us page of the web application.
2. Fill out the Contact Us form with valid credentials based on the test data.
3. Submit the Contact Us form.

**Test Data:**

Name: "Mat"

Subject:"Field validations."

Message:"Dear [Site Support Team/Technical Support Team], I hope this email finds you well.I am writing to request the addition of validation on an important field within the [https://www.automationexercise.com/]. This enhancement will help ensure data accuracy, integrity, and provide a better user experience for all users."

Email: "justfortest777@abv.bg"

**Expected Results:**
- A successful message "Success! Your details have been submitted successfully." is displayed after submitting the Contact Us form.
   
**Test Case 3:** Verify Successful Subscription from Contact Us Page

Test ID: TC_Contact_003

Priority: High

**Description:** 
- Verify that the user can successfully subscribe to the newsletter from the Contact Us page using valid credentials.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the Contact Us page.

**Test Steps:**
1. Scroll to the bottom of the Contact Us page to ensure the subscription section is in view.
2. Enter the valid email address in the subscription field.
3. Click on the "Subscribe" button.

**Test Data:**
Email: "justfortest777@abv.bg"

**Expected Results:**
- The correct successful subscribe message is displayed.

**Test Case 4:** Verify Subscribe with Invalid Email from Contact Us Page

Test ID: TC_Contact_004

Priority: Medium

**Description:** 
- Verify that the user cannot subscribe to the newsletter from the Contact Us page using invalid email addresses.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the Contact Us page.

**Test Steps:**
1. Scroll to the bottom of the Contact Us page to ensure the subscription section is in view.
2. Provide an invalid email address as test data.
3. Fill in the email address field with the specified test email based on the test data.
4. Click on the "Subscribe" button.

**Test Data:**
- Email Scenarios:
        email: null
        email: "invalidEmail"
        email: "invalidEmail@"

**Expected Results:**
- The following error messages are displayed to the user based on the provided email scenarios:
  - When email is null: An error message "Please fill out this field." is displayed.
  - When email is "invalidEmail": An error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
  - When email is "invalidEmail@": An error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.

**Test Case 5:** Verify Correct Display of Feedback Information

Test ID: TC_Contact_005

Priority: Low

**Description:** 
- Verify that the correct feedback information is displayed on the Contact Us page.

**Preconditions:**
- The web application is accessible and operational.

**Test Steps:**
1. Navigate to the ContactUs page of the web application.

**Test Data:**

**Expected Results:**
- The feedback title "FEEDBACK FOR US" and text information "We really appreciate your response to our website.Kindly share your feedback with us at feedback@automationexercise.com.If you have any suggestion areas or improvements, do let us know. We will definitely work on it.Thank you" are displayed correctly on the Contact Us page.
