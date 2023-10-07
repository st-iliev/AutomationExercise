## API Login Test Cases

### Test Case 1: Post Login With Missing Credentials

Test ID: TC_Login_001

Priority: High

**Description:** 
- Verify that the API returns a BadRequest status when attempting to login with missing credentials.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/verifyLogin"
- password : "testqa1"

**Test Steps:**

1. Send a POST request to the specified endpoint with the prepared parameters.

**Expected Results:**

- Response status code: 200
- Response ResponseCode is 400.
- Response Message is "Bad request, email or password parameter is missing in POST request."

### Test Case 2: Post Login With Invalid Credentials

Test ID: TC_Login_002

Priority: High

**Description:** 
- Verify that the API returns a NotFound status when attempting to login with invalid credentials.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/verifyLogin"
- password : "testqa1"

**Test Steps:**

1. Send a POST request to the specified endpoint with the prepared parameters.

**Expected Results:**

- Response status code: 200
- Response ResponseCode is 404.
- Response Message is "User not found!"

### Test Case 3: Post Login With Valid Credentials

Test ID: TC_Login_003

Priority: High

**Description:** 
- Verify that the API successfully logs in with valid credentials.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/verifyLogin"
- email: "qatest@gmail.com"
- password : "testqa1"

**Test Steps:**

1. Send a POST request to the specified endpoint with the prepared parameters.

**Expected Results:**

- Response status code: 200
- Response ResponseCode is 200.
- Response Message is "User exists!"
