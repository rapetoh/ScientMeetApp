namespace ScientMeetApp.Pages;

public partial class WelcomeScreen2 : ContentPage
{
	public WelcomeScreen2()
	{
		InitializeComponent();
	}
    private void Suivant2(object sender, EventArgs e)
    {
        // Cr�er une nouvelle instance de la page vers laquelle vous souhaitez rediriger
        var nextPage = new WelcomeScreen3();

        // Acc�der � la NavigationPage actuelle (si vous utilisez une navigation bas�e sur la pile)
        var navigation = Application.Current.MainPage.Navigation;

        // Utiliser la m�thode de navigation appropri�e pour rediriger vers la nouvelle page
        // Par exemple, utiliser PushAsync pour ajouter la page � la pile de navigation
        navigation.PushAsync(nextPage);

    }
}