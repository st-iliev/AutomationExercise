# API User Account Test Cases

### Test Case 1: Get User Account By Email

Test ID: TC_UserAccount_001

Priority: High

**Description:** 
- Verify that the API successfully retrieves a user account by email.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/getUserDetailByEmail"
- email: "qatest@gmail.com"

**Test Steps:**

1. Send a GET request to the specified endpoint with the prepared parameters.

**Expected Results:**
- Response status code: 200
- Response JSON: Acount details
