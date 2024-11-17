using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class TelaInicial : ContentPage
{
    public TelaInicial() => InitializeComponent();

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Evento h = new Evento
            {
                QtdParticipantes = Convert.ToInt32(txt_numeroParticipantes.Text),
                ValorPorParticipante = Convert.ToDouble(txt_valorParticipantePorDia.Text),
                DataFim = dtpck_fim.Date,
                DataInicio = dtpck_inicio.Date,
                LocalEvento = txt_localEvento.Text,
                NomeEvento = txt_nomeEvento.Text,
            };

            Navigation.PushAsync(new OrcamentoFinal()
            {
                BindingContext = h
            });
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "OK");
        }

    }
}