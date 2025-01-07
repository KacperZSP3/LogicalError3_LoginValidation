namespace LoginValidation;
//Sprawdzenie czy dane do logowania są poprawnie sprawdzane.
public partial class MainPage : ContentPage
{
    string validUsername = "admin";
    string validPassword = "password123";

    public MainPage()
    {
        InitializeComponent();
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
