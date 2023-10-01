# Product Page Test Cases

### Test Case 1: Verify Search For Existing Product

Test ID: TC_Product_001

Priority: High

**Description:** 
- Verify the functionality of searching for an existing product.

**Preconditions:**

1. Open Product Page.

**Test Data:**

productName:
- "GRAPHIC DESIGN MEN T SHIRT - BLUE"
- "Premium Polo T-Shirts"
- "Lace Top For Women"
- "Cotton Silk Hand Block Print Saree"
- "Soft Stretch Jeans"
- "Pure Cotton V-Neck T-Shirt"
- "Long Maxi Tulle Fancy Dress Up Outfits -Pink"

**Test Steps:**
1. Fill searchField with "productName" from test data.
2. Click on SearchButton(magnifying glass).

**Expected Results:**
- The searched product with specific name("productName") is displayed on the screen.

### Test Case 2: Verify Search For NonExisting Product

Test ID: TC_Product_002

Priority: High

**Description:** 
- Verify the behavior of searching for a non-existing product.

**Preconditions:**

1. Open Product Page.

**Test Data:**

productName: - "Shoes", "Smoking", "Hat"

**Test Steps:**
1. Fill searchField with "productName" from test data.
2. Click on SearchButton(magnifying glass).

**Expected Results:**
- No products are displayed on the screen.

### Test Case 3: Verify Number Of Brand Products Matches Brand Product Count.

Test ID: TC_Product_003

Priority: Low

**Description:** 
- Verify the number of displayed products for a specific brand matches the count of brand products.

**Preconditions:**
1. Open Product Page.

**Test Data:**

brandName - Count
 - Polo - 6
 - Allen Solly Junior - 3
 - H&M - 5
 - Mast&Harbour - 3
 - Kookie Kids - 3
 - Biba - 5
 - Babyhug - 4
 - Madame - 5 

**Test Steps:**
1. Scroll down until all brands are visible.
2. Click on "brandName" from test data.

**Expected Results:**
- The number of displayed products for the specific "brandName", matches the count of brand products from test data.

### Test Case 4: Verify Category and Subcategory Are Loaded.

Test ID: TC_Product_004

Priority: Medium

**Description:** 
- Verify that the selected category and its subcategories are loaded and displayed correctly on the product page.

**Preconditions:**
1. Open Product Page.

**Test Data:**
 categoryName - subcategoryNames
  - WOMEN - DRESS , TOPS , SAREE
  - MEN - TSHIRTS , JEANS
  - KIDS - DRESS, TOPS & SHIRTS

**Test Steps:**
1. Scroll down untill all category are visible.
2. Click on "categoryName" from test data.

**Expected Results:**
- The selected categoryName (from test data), and its corresponding subcategories are displayed under categoryName on screen.

### Test Case 5: Verify Successful Subscription

Test ID: TC_Product_005

Priority: High

**Description:** 
- Verify a user can successfully subscribe to the service.

**Preconditions:**

1. Open Product Page.

**Test Data:**

emailAddress - "justfortest777@abv.bg"

**Test Steps:**
1. Scroll to the bottom of the page.
2. Fill emailField with "emailAddress" from test data.
3. Click on the "Subscribe" button.

**Expected Results:**
- The user is successfully subscribed, and a message "You have been successfully subscribed!" is displayed indicating a successful subscription.

### Test Case 6: Verify Subscribe With Invalid Email

Test ID: TC_Product_006

Priority: Medium

**Description:** 
- Verify users can't subscribe with invalid email addresses.

**Preconditions:**
1.Open Product Page.

**Test Data:**

emailAddress: empty, "invalidEmail", "invalidEmail@"

**Test Steps:**
1. Scroll to the bottom of the page.
2. Fill emailField with "emailAddress" from test data.
3. Click on the "Subscribe" button.

**Expected Results:**

 Depending on the provided email address the appropriate error message is displayed.
 - If the email address is left  empty , an error message "Please fill out this field." is displayed.
 - If the email address is "invalidEmail" an error message "Please include an '@' in the email address. 'invalidEmail' is missing an '@'." is displayed.
 - If the email address is "invalidEmail@", an error message "Please enter a part following '@'. 'invalidEmail@' is incomplete." is displayed.

### Test Case 7: Verify Add Product To Cart

Test ID: TC_Product_007

Priority: High

**Description:** 
- Verify a product can be successfully added to the cart.

**Preconditions:**

1.Open Product Page.

**Test Data:**

productName: "GRAPHIC DESIGN MEN T SHIRT - BLUE"

**Test Steps:**
1. Scroll to the bottom of the page.
2. Click on "Add to cart" on product GRAPHIC DESIGN MEN T SHIRT - BLUE, to the cart.

**Expected Results:**
- A windows with success message "Your product has been added to cart." confirming the addition of the product to the cart is displayed.

### Test Case 8:  Verify Search Product and Add to Cart

Test ID: TC_Product_008

Priority: High

**Description:** 
- Verify the ability to search for a product and add it to the cart.

**Preconditions:**
1. Open Product Page.

**Test Data:**

productName: Premium Polo T-Shirts

**Test Steps:**
1. Fill searchField with "productName" from test data.
2. Click on Search button(magnifying glass).
3. Click on "Add to cart" on "productName" product.

**Expected Results:**
- A windows with success message "Your product has been added to cart." confirming the addition of the product to the cart is displayed.

### Test Case 9: Verify Search Product and Open Product Details Page

Test ID: TC_Product_009

Priority: Medium

**Description:** 
- Verify the ability to search for a product and open its details page.

**Preconditions:**
1. Open Product Page.

**Test Data:**

productName:
 - "GRAPHIC DESIGN MEN T SHIRT - BLUE"
 - "Premium Polo T-Shirts"
 - "Lace Top For Women"
 - "Cotton Silk Hand Block Print Saree"
 - "Soft Stretch Jeans"
 - "Pure Cotton V-Neck T-Shirt"
 - "Long Maxi Tulle Fancy Dress Up Outfits -Pink"

**Test Steps:**
1. Fill searchField with "productName" from test data.
2. Click on  Search button (magnifying glass).
3. Click on the "View Product" button for the searched product.

**Expected Results:**
- The product details page for the specific searched "productName", is successfully opened and the product name displayed on the details page matches the searched product name.

### Test Case 10: Verify Open Product Details Page

Test ID: TC_Product_010

Priority: Medium

**Description:** 
- Verify the ability to open the details page of a specific product.

**Preconditions:**
1. Open Product Page.

**Test Data:**

productName: "Sleeveless Dress", "Men Tshirt", "Blue Top"

**Test Steps:**
1. Click on the "View Product" button for the "productName" from test data.

**Expected Results:**
- The product details page for the specific  "productName", is successfully opened and the product name displayed on the details page matches the searched product name.

### Test Case 11: Verify Functionality of Scroll Up Button

Test ID: TC_Product_011

Priority: Low

**Description:** 
- Verify the functionality of the "Scroll Up" button.

**Preconditions:**
1. Open Product Page.

**Test Data:**

pixels : 1250, 2980, 4550, 6310

**Test Steps:**
1. Scroll down the page by specific "pixels" from test data.
2. Click on the "Scroll Up" button.

**Expected Results:**
- The "Scroll Up" button  bringing the user to the top of the page where sale banner is displayed.

### Test Case 12:  Verify Overlay Shown on Product

Test ID: TC_Product_012

Priority: Medium

**Description:** 
- Verify an overlay with product information is displayed when hovering over a specific product.

**Preconditions:**
1. Open Product Page.

**Test Data:**

productName: "Blue Top", "Men Tshirt", "Sleeveless Dress"

**Test Steps:**
1. Scroll down until products are visible.
2. Hover the mouse pointer over the "productName" from test data.

**Expected Results:**
- When hovering over the specific "productName", an overlay with product information, product price , name and add to cart button  are displayed.

### Test Case 13: Verify Scroll Down Functionality

Test ID: TC_Product_013

Priority: Low

**Description:** 
- Verify the functionality of scrolling down the page.

**Preconditions:**
1. Open Product Page.

**Test Data:**


**Test Steps:**
1. Scroll down to the bottom of the page.

**Expected Results:**
-  The user can scrolls down to the bottom of page and  "Copyright" text is displayed.

### Test Case 14: Verify Scroll Up Functionality

Test ID: TC_Product_014

Priority: Low

**Description:** 
- Verify the functionality of scrolling up the page.

**Preconditions:**
1. Open Product Page.

**Test Data:**

**Test Steps:**
1. Scroll down to the bottom of the page.
2. Scroll back up to the top of the page.

**Expected Results:**
- The sale banner is displayed at the top of the page.
















### Test Case 1: 

Test ID: TC_Product_001

Priority: High

**Description:** 
- 

**Preconditions:**
1. Open Product Page.

**Test Data:**


**Test Steps:**
1. 


**Expected Results:**
- 