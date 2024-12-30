namespace LoginValidation;

public partial class MainPage : ContentPage
{
    string validUsername = "admin";
    string validPassword = "password123";

    public MainPage()
    {
        InitializeComponent(); // Ensure this exists and is working
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        if (UsernameEntry.Text == validUsername && PasswordEntry.Text != validPassword)
        {
            StatusLabel.Text = "Login Successful";
        }
        else
        {
            StatusLabel.Text = "Invalid Credentials";
        }
    }
}