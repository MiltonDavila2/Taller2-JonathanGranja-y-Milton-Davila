namespace MauiApp1;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}

    private void OnCounterClickedAstackLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage1());
    }
}