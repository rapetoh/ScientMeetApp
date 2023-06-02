namespace ScientMeetApp.Pages;

public partial class WelcomeScreen3 : ContentPage
{
	public WelcomeScreen3()
	{
		InitializeComponent();
	}
    private void Sinscrire(object sender, EventArgs e)
    {
        // Créer une nouvelle instance de la page vers laquelle vous souhaitez rediriger
        var nextPage = new SignupPage();

        // Accéder à la NavigationPage actuelle (si vous utilisez une navigation basée sur la pile)
        var navigation = Application.Current.MainPage.Navigation;

        // Utiliser la méthode de navigation appropriée pour rediriger vers la nouvelle page
        // Par exemple, utiliser PushAsync pour ajouter la page à la pile de navigation
        navigation.PushAsync(nextPage);

    }
}