## API Register User Account Test Cases

### Test Case 1: Register New User

Test ID: TC_Register_001

Priority: High

**Description:** 
- Verify that the API allows registering a new user with valid registration details.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/createAccount"
- name : "Mat"
- email : "qatest@gmail.com"
- password : "testqa1"
- title: "Mr"
- birth_date: "10"
- birth_month: "may"
- birth_year: "1990"
- firstname: "Matthew"
- lastname: "Tudor"
- company: "Space Z"
- address1: "bul.Bulgaria"
- address2: "str.Yalta"
- country: "Australia"
- zipcode: "10005"
- state: "Sula"
- city: "Hamilton"
- mobile_number : "+365895874"

**Test Steps:**

1. Send a POST request to the specified endpoint with the prepared parameters.

**Expected Results:**

- Response status code is 200
- Response ResponseCode is 201.
- Response Message is "User created!".

### Test Case 2: Register Existing User

Test ID: TC_Register_002

Priority: High

**Description:** 
- Verify that the API allows registering a new user with valid registration details.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/createAccount"
- name : "Mat"
- email : "qatest@gmail.com"
- password : "testqa1"
- firstname: "Matthew"
- lastname: "Tudor"
- company: "Space Z"
- address1: "bul.Bulgaria"
- country: "Australia"
- zipcode: "10005"
- state: "Sula"
- city: "Hamilton"
- mobile_number : "+365895874"

**Test Steps:**

1. Send a POST request to the specified endpoint with the prepared parameters.

**Expected Results:**

- Response status code is 200
- Response ResponseCode is 400.
- Response Message is "Email already exists!".