namespace MauiApp1.Views;

public partial class OrcamentoFinal : ContentPage
{
	public OrcamentoFinal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
           Navigation.PushAsync(new TelaInicial());
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }
    }
}