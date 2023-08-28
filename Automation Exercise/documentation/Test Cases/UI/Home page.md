# Home Page Test Cases

**Test Case 1:** Verify Navigation Links Are Present. 

Test ID: TC_NavLinks_001  
Priority: High  

**Description:** 
- Verify that all navigation links are displayed on the homepage.
**Preconditions:**
1. The web application is accessible and operational.
2. The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.      

**Expected Results:**
- All navigation links are displayed on top of home page.

**Test Case 2:** Verify Clicking on Arrows Switches Carousel Content Image and Active Indicator

Test ID: TC_Carousel_001

Priority: Medium

**Description:** 
- Verify that clicking on the arrows to switch the carousel content image works correctly and that the active indicator updates accordingly.

**Preconditions:**
1. The web application is accessible and operational.
2. The user is on the homepage of the web application.
3. The carousel with content images is displayed.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Click on the specified arrow (left or right) to switch the carousel content.

**Test Data**
- side parameter: Specify either "left" or "right" to indicate the arrow to click.

**Expected Results:**
- The correct page is loaded, and the web banner is displayed.
- After clicking on the specified arrow, the carousel content updates as expected:
  - The correct carousel content texts are displayed.
  - The content image has been switched to the next image.
  - The active indicator corresponds to the current content image.

**Test Case 3:** Verify Clicking on Indicators Switches Carousel Content Image and Active Indicator

  Test ID: TC_Carousel_002

  Priority: Medium

**Description:** 
- Verify that clicking on the carousel indicators switches the carousel content image and updates the active indicator accordingly.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.
- The carousel with content images and indicators is displayed.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Click on the specified carousel indicator.

**Test Data:**
- indicator parameter: Specify the indicator number (e.g., "first", "second", "third", etc.) to indicate the indicator to click.

**Expected Results:**
- After clicking on the specified indicator, the carousel content updates as expected:
  - The correct carousel content texts are displayed.
  - The content image has been switched to the image corresponding to the clicked indicator.
  - The active indicator corresponds to the clicked indicator.

**Test Case 4:** Verify Category and Subcategory Are Display

    Test ID: TC_Category_001
    Priority: Medium

**Description:** 
- Verify that all categories and their corresponding subcategories are displayed correctly on home page.

**Preconditions:**
 - The web application is accessible and operational.
 - The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure categories and subcategories are in view.
3. Select the specified category.

**Test Data:**
- name of category: "WOMEN" -> names of subcategory: "DRESS", "TOPS" , "SAREE".
- name of category: "MEN" -> names of subcategory: "TSHIRTS", "JEANS".
- name of category: "KIDS" -> names of subcategory: "DRESS" , "TOPS & SHIRTS".

**Expected Results:**
- After clicking on selected category:
   - "WOMEN" is selected: Women category and subcategories are displayed.
   - "MEN" is selected: Men category and subcategories are displayed.
   - "KIDS" is selected: Kids category and subcategories are displayed.

**Test Case 5:** Verify Number of Brand Products Matches Brand Product Count

Test ID: TC_BrandProduct_001

Priority: Medium

**Description:** 
-Verify that the number of displayed brand products matches the expected brand product count for the specified brand.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure the brand products section is in view.
3. Select the specified brand.

**Test Data:**
- brands names: "POLO", "H&M", "MADAME", "MAST & HARBOUR", "BABYHUG", "ALLEN SOLLY JUNIOR", "KOOKIE KIDS", "BIBA". 

**Expected Results:**
- The number of displayed brand products is the same as the expected brand product count for the selected brand.

**Test Case 6:** Verify Successful Subscription

 Test ID: TC_Subscribe_001

 Priority: Medium

**Description:** 
- Verify that a user can successfully subscribe using valid credentials, and the appropriate success message is displayed.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll to the bottom of the page to ensure the subscription section is in view.
3. Fill email adress with valid credential.
4. Click on the "Subscribe" button.

**Test Data:**
- email : "justfortest777@abv.bg".

**Expected Results:**
-  The correct successful subscription message "You have been successfully subscribed!" is displayed to the user.

**Test Case 7:** Verify Subscribe with Invalid Email

Test ID: TC_Subscribe_002

Priority: Medium

**Description:** 
-Verify that the user is unable to subscribe with invalid email addresses, and appropriate error messages are displayed.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll to the bottom of the page to ensure the subscription section is in view.
3. Fill in the email address field with the specified test email based on the test scenario.
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

**Test Case 8:** Verify Navigation Links Lead to Correct Pages

Test ID: TC_NavLinks_002

Priority: Medium

**Description:** 
- Verify that all navigation links lead the user to the correct pages on the web application.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Click on provided navigation link.

**Test Data:**
- navigation links:  "Products," "Cart," "Login," "Test Cases," "API Testing,","Video Tutorials", "Contact us."

**Expected Results:**
- User is leads to correct pages.
  - When is clicked on "Products": The products navigation link leads to the correct page.
  - When is clicked on "Cart": The cart navigation link leads to the correct page.
  - When is clicked on "Login": The login navigation link leads to the correct page.
  - When is clicked on "Test Cases": The Test Cases navigation link leads  to the correct page.
  - When is clicked on "API Testing": The API testing navigation link leads to the correct page.
  - When is clicked on "Video Tutorials": The Video Tutorials navigation link leads to the correct page.
  - When is clicked on "Contact us": The contact us navigation link leads to the correct page.

**Test Case 9:** Verify Correct Products from Subcategory Are Loaded

Test ID: TC_Products_001

Priority: Medium

**Description:** 
- Verify that the correct products from the specified subcategory are loaded and displayed on the web application.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure the product section is in view.
3. Select the specified categoryName.
4. Select the specified subCategoryName to filter products.

**Test Data:**
- category and subcategory Scenarios:

  - categoryName : "WOMEN", subCategoryName : "DRESS"
  - categoryName : "WOMEN", subCategoryName : "TOPS"
  - categoryName : "WOMEN", subCategoryName : "SAREE"
  - categoryName : "MEN", subCategoryName : "TSHIRTS"
  - categoryName : "MEN", subCategoryName : "JEANS"
  - categoryName : "KIDS", subCategoryName : "DRESS"
  - categoryName : "KIDS", subCategoryName : "TOPS & SHIRTS"   

**Expected Results:**
- The correct product subcategory title is displayed.

**est Case 10:** Verify Scroll Down Functionality

Test ID: TC_Scroll_001

Priority: Medium

**Description:** 
- Verify that the scroll-down functionality of the web page works correctly and displays the footer with the copyright text.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Perform a scroll-down action to the bottom of the page.

**Test Data:**


**Expected Results:**
- The copyright text is displayed in the footer after scrolling down.

**Test Case 11:** Verify Scroll Up Functionality

Test ID: TC_Scroll_002

Priority: Medium

**Description:** 
- Verify that the scroll-up functionality of the web page works correctly and displays the correct carousel texts.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Perform a scroll-down action to the bottom of the page.
3. Perform a scroll-up action to return to the top of the page.

**Test Data:**

**Expected Results:**
- The correct carousel texts are displayed on the page after scrolling up.

**Test Case 12:** Verify Opening Product Details Page from Home Page

Test ID: TC_ProductDetails_001

Priority: Medium

**Description:** 
- Verify that the user can successfully open the details page of a product from the home page, and the correct product details are displayed.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure the product section is in view.
3. Click on the specified productName to open the product details page.

**Test Data:**
- productName Scenarios:
  - productName : "Sleeveless Dress"
  - productName : "Men Tshirt"
  - productName : "Blue Top"

**Expected Results:**
- The correct product details page is loaded and correct product name is displayed on the details page.

**Test Case 13:** Verify Website Logo Loaded Properly

Test ID: TC_Logo_001

Priority: Medium

**Description:** 
- Verify that the website logo is displayed correctly on the header.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.

**Test Data:**

**Expected Results:**
-The website logo is displayed properly on the header. 

**Test Case 14:** Verify Functionality of Scroll Up Button

Test ID: TC_ScrollUp_001

Priority: Medium

**Description:** 
- Verify that the "Scroll Up" button functionality works as expected, bringing the user back to the top of the page.

**Preconditions:**
- The web application is accessible and operational.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure that the height value (specified in pixels) is reached.
3. Click on the "Scroll Up" button.

**Test Data:**
height(in pixels) Scenarios:
 - height : 1250
 - height : 2980
 - height : 4550
 - height : 6310

**Expected Results:**
- The website logo and carousel are displayed on the page.

**Test Case 15:** Verify Functionality of Recommended Items Arrows

Test ID: TC_RecommendedItems_001

Priority: Medium

**Description:** 
-Verify that the functionality of the side arrows for recommended items works correctly, allowing the user to navigate through recommended items.

**Preconditions:**
- The web application is accessible and operational.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure that the recommended items section is in view.
3. Click on the specified side arrow.
    
**Test Data:**
side Scenarios:
  - side : "left"
  - side : "left"
  - side : "right"
  - side : "right"

**Expected Results:**
- The names of the current recommended items have changed after clicking the specified side arrow.

**Test Case 16:** Verify Overlay Shown on Product

Test ID: TC_Overlay_001

Priority: Medium

**Description:** 
- Verify that the overlay information for a specific product is displayed when hovering over the product.

**Preconditions:**
- The web application is accessible and operational.
- The user is on the homepage of the web application.

**Test Steps:**
1. Navigate to the homepage of the web application.
2. Scroll down on the page to ensure the product section is in view.
3. Hover over the specified productName.

**Test Data:**
productName Scenarios:
 - productName: "Blue Top"
 - productName: "Men Tshirt"
 - productName: "Sleeveless Dress"

**Expected Results:**
- The overlay information for the specified product name and price are displayed when hovering over the product.
