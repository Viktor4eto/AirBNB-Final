## AirBNB Application Readme

### Overview

This document provides comprehensive documentation for the AirBNB application codebase. The application is designed to facilitate user authentication, password management, apartment browsing, and reservation functionalities.

### Classes and Functions

#### `LogIn.cs`

- **`LogIn` Class**: Represents the login form of the application.
- **`ApplyTheme` Method**: Applies the selected theme (light or dark) to the login form and its controls.
- **`UpdateControlsForTheme` Method**: Updates the visual properties of all controls on the login form based on the selected theme.
- **`signIn_Click` Method**: Validates user input and attempts user authentication.
- **`changePassword_click` Method**: Navigates to the password change screen.
- **`onLoad` Method**: Initializes the database connection when the login form is loaded.
- **`ThemeComboBox_SelectionChanged` Method**: Applies the selected theme when the theme selection dropdown changes.

#### `ChangePassword.cs`

- **`ChangePassword` Class**: Represents the password change form of the application.
- **`ApplyTheme` Method**: Applies the selected theme (light or dark) to the password change form and its controls.
- **`UpdateControlsForTheme` Method**: Updates the visual properties of all controls on the password change form based on the selected theme.
- **`onConfirm` Method**: Validates user input and updates the user's password in the database.
- **`rePasswordValidating` Method**: Validates whether the re-entered password matches the new password.

#### `Form1.cs`

- **`Form1` Class**: Represents the main application form where users can browse apartments and make reservations.
- **`ApplyTheme` Method**: Applies the selected theme (light or dark) to the main application form and its controls.
- **`UpdateControlsForTheme` Method**: Updates the visual properties of all controls on the main application form based on the selected theme.
- **`button1_Click` Method**: Executes a SQL query to fetch and display apartment data based on user-selected criteria.
- **`clear_Click` Method**: Clears the apartment search criteria and resets the data grid view.
- **`book_Click` Method**: Opens the reservation form to allow users to book an apartment.
- **`delete_click` Method**: Deletes the user account from the database and returns to the login screen.

#### `book.cs`

- **`book` Class**: Represents the reservation form where users can book apartments.
- **`ApplyTheme` Method**: Applies the selected theme (light or dark) to the reservation form and its controls.
- **`UpdateControlsForTheme` Method**: Updates the visual properties of all controls on the reservation form based on the selected theme.
- **`reserve_Click` Method**: Validates user input and reserves the selected apartment if available.
- **`phone_Validating` Method**: Validates the format of the phone number entered by the user.

#### `authenticate.cs`

- **`User` Class**: Represents a user object with properties like id, username, email, and phone.
- **`DatabaseManager` Class**: Responsible for handling database operations, including user authentication and password management.
- **`AuthenticateUser` Method**: Authenticates user credentials and returns a user object if authentication is successful.
- **`RetrieveUserInformation` Method**: Retrieves user information from the database based on the provided username and password.

### Design Decisions

- **Theming**: The application supports both light and dark themes for visual customization, providing users with a personalized experience.
- **Database Management**: Database operations are encapsulated within the `DatabaseManager` class, ensuring better organization and maintainability.
- **User Authentication**: User authentication is performed securely using SQL queries to validate user credentials against stored data in the database.

### Conclusion

The AirBNB application offers a user-friendly interface for browsing apartments, making reservations, and managing user accounts. With clear documentation and well-structured code, the application is easy to understand, modify, and maintain.
