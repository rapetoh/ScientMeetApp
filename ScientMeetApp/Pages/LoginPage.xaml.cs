namespace ScientMeetApp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

	}
    public async void OnSignupButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignupPage());
    }
    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        LoadingOverlay.IsVisible = true;

        try
        {
            await Task.Delay(2000);
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erreur", "Une erreur s'est produite lors de la recherche de données.", "OK");
        }
        finally
        {
            LoadingOverlay.IsVisible = false;
        }
    }
    void OnEntryPasswordChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = password.Text;
    }
    void OnEntryPasswordCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    void OnEntryEmailChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = email.Text;
    }
    void OnEntryEmailCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
    void HomePage(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(Pages.HomePage)}");
    }
 }