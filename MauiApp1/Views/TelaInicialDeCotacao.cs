namespace MauiApp1.Views;

public class TelaInicialDeCotacao : ContentPage
{
	public TelaInicialDeCotacao()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}