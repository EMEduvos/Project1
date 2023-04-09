using Project1.Question2.Desktop.Extensions;
using System.Text.RegularExpressions;

namespace Project1.Question2.Desktop
{
  public partial class LoginForm : Form
  {
    private CustomErrorProvider _userNameErrorProvider = new();
    private CustomErrorProvider _passwordErrorProvider = new();

    private const string InvalidUserNameMessage = "Email address is invalid.  Email address should be a valid Eduvos address.";
    private const string InvalidPasswordMessage = "Password is invalid.  Passwords should conform to the following:\n\n" +
        "Be a minimum length of 8 characters\n" +
        "Contain at least one UPPER CASE character\n" +
        "Contain at least on lower case character\n" +
        "Contain at least one number\n" +
        "Contain at least one of the following special characters @#$%^&+=";


    public LoginForm()
    {
      InitializeComponent();

      ConfigureUserNameErrorProvider();
      ConfigurePasswordErrorprovider();
    }

    /// <summary>
    /// Configures the properties of the UsernameErrorProvider
    /// </summary>
    private void ConfigureUserNameErrorProvider()
    {
      _userNameErrorProvider = new CustomErrorProvider();
      _userNameErrorProvider.SetIconAlignment(txtUsername, ErrorIconAlignment.MiddleRight);
      _userNameErrorProvider.SetIconPadding(txtUsername, 2);
      _userNameErrorProvider.BlinkRate = 500;
      _userNameErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
    }

    /// <summary>
    /// Configures the properties of the PasswordErrorProvider
    /// </summary>
    private void ConfigurePasswordErrorprovider()
    {
      _passwordErrorProvider = new CustomErrorProvider();
      _passwordErrorProvider.SetIconAlignment(txtPassword, ErrorIconAlignment.MiddleRight);
      _passwordErrorProvider.SetIconPadding(txtPassword, 2);
      _passwordErrorProvider.BlinkRate = 500;
      _passwordErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

    }

    /// <summary>
    /// Handles the validation of the <see cref="txtUsername"/> textbox
    /// </summary>
    private void Username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      // Clear any existing errors first, before validating again.
      _userNameErrorProvider.Clear();

      // If we already have a password and it is valid, enable login.
      // It will be disabled again of the user types an incorrect username
      if (txtPassword.Text.Length > 0 && !_passwordErrorProvider.HasErrors)
      {
        btnLogin.Enabled = true;
        btnLogin.Focus();
      }

      // Validate the username
      if (!ValidUserName(txtUsername.Text, out var errorMessage))
      {
        e.Cancel = true;
        txtUsername.Select(0, txtUsername.TextLength);
        _userNameErrorProvider.SetError(txtUsername, errorMessage);
        btnLogin.Enabled = false;
      }
    }

    /// <summary>
    /// Validates the username against the set business rules
    /// </summary>
    /// <param name="text">The text to be validated</param>
    /// <param name="errorMessage">The message to be returned</param>
    /// <returns>A boolean indicating whether the text is valid or not</returns>
    private static bool ValidUserName(string text, out string errorMessage)
    {
      errorMessage = InvalidUserNameMessage;

      if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
        return false;

      // This is the patter we expect to see in the username
      string pattern = @"\b(@vossie\.net)\b";

      // If the pattern is matched, the username is good
      if (Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase))
        return true;


      return false;
    }

    /// <summary>
    /// Handles the validation of the <see cref="txtPassword"/> textbox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TxtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      // Clear all previous errors
      _passwordErrorProvider.Clear();

      // If we have a username already and it is valid, enable to button
      // If the password is invalid, it will be disabled again
      if (txtUsername.Text.Length > 0 && !_userNameErrorProvider.HasErrors)
      {
        btnLogin.Enabled = true;
        btnLogin.Focus();
      }

      // Validate the password
      if (!ValidPassword(txtPassword.Text, out var errorMessage))
      {
        e.Cancel = true;
        txtPassword.Select(0, txtPassword.TextLength);
        _passwordErrorProvider.SetError(txtPassword, errorMessage);
        btnLogin.Enabled = false;
      }
    }


    /// <summary>
    /// Validates whether the password conforms to the bubsiness rules
    /// </summary>
    /// <param name="text">The text to be validated</param>
    /// <param name="errorMessage">The error message to be returned</param>
    /// <returns>A boolean, indicating whether the password is valid or not</returns>
    private static bool ValidPassword(string text, out string errorMessage)
    {
      // Assume that the passowrd is not valid

      errorMessage = InvalidPasswordMessage;

     bool result = !string.IsNullOrWhiteSpace(text) && text.Length >= 8;

      // If the result is valid, see whether we can invalidate it by checking:
      // lower case
      if (result)
        result = Regex.IsMatch(text, @"[a-z]");

      // upper case
      if (result)
        result = Regex.IsMatch(text, @"[A-Z]");

      // numbers
      if (result)
        result = Regex.IsMatch(text, @"[\d]");

      // special characters
      if (result)
        result = Regex.IsMatch(text, @"[^\da-zA-Z]$");

      return result;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      Hide();
      using DashboardForm dashboardForm = new();
      dashboardForm.ShowDialog();

      Show();
    }
  }
}