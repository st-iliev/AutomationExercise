# API Test Cases

### Test Case 1: Get All Brands

Test ID: TC_Brand_001

Priority: High

**Description:** 
- Verify that the API successfully retrieves the list of all products.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/productsList"

**Test Steps:**

1. Send a GET request to the API endpoint to retrieve the list of all products.

**Expected Results:**
- Response status code: 200
- Response JSON: All products list

### Test Case 2: Post All Brands

Test ID: TC_Brand_002

Priority: High

**Description:** 
- Verify that the API returns a MethodNotAllowed status when attempting to POST all brands.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/productsList"

**Test Steps:**

1. Send a POST request to the specified endpoint.

**Expected Results:**
- Response status code: 200
- Response ResponseCode is HttpStatusCode.MethodNotAllowed.
- Response Message is "This request method is not supported."

### Test Case 3: Put All Brands

Test ID: TC_Brand_003

Priority: High

**Description:** 
- Verify that the API returns a MethodNotAllowed status when attempting to PUT all brands.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/productsList"

**Test Steps:**

1. Send a PUT request to the specified endpoint 

**Expected Results:**
- Response status code: 200
- Response ResponseCode is HttpStatusCode.MethodNotAllowed.
- Response Message is "This request method is not supported."

