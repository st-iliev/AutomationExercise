# API Update User Account Test Cases

### Test Case 1: Update User Account

Test ID: TC_UpdateAccount_001

Priority: High

**Description:** 
- Verify that the API allows updating a user account with valid update details.

**Preconditions:**

**Test Data:**

- Endpoint: "https://automationexercise.com/api/updateAccount"
- name : "Mat"
- email : "qatest@gmail.com"
- password: "testqa1"
- title: "Mr"
- birth_date: "14"
- birth_month: "novembur"
- birth_year: "1995"
- firstname: "John"
- lastname: "Tudor"
- company: "Space Y"
- address1: "bul.Freedom"
- address2: "str.Doom"
- country: "United State"
- zipcode: "15847"
- state: "Utah"
- city: "Orem"
- mobile_number: "+397114779"


**Test Steps:**

1. Send a PUT request to the specified endpoint with the prepared parameters.

**Expected Results:**
- Response status code: 200
- Response ResponseCode is 200.
- Response Message is "User updated!"