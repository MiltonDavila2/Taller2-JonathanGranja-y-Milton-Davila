namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}


    private void OnCounterClickedAstackLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage2());
    }
}