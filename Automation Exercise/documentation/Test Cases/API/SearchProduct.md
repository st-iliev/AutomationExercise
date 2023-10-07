# API Search Product Test Cases

### Test Case 1: Search for Existing Product

Test ID: TC_Search_001

Priority: High

**Description:** 
- Verify that the API successfully searches for existing products based on search criteria.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/searchProduct"
- search_product : "Dress"

**Test Steps:**

1. Send a POST request to the specified endpoint with the prepared parameters.

**Expected Results:**
- Response status code: 200
- Response JSON: Searched products list

### Test Case 2: Search for Product Without Parameter

Test ID: TC_Search_002

Priority: High

**Description:** 
- Verify that the API returns a BadRequest status when attempting to search for a product without the required search parameter.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/searchProduct"

**Test Steps:**

1. Send a POST request to the specified endpoint without the required search parameter.

**Expected Results:**
- Response status code: 200
- Response ResponseCode is 400.
- Response Message is "Bad request, search_product parameter is missing in POST request."