
namespace MauiApp1.Models
{
    public class Evento
    {
        public int QtdParticipantes { get; set; }
        public double ValorPorParticipante { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public required string NomeEvento { get; set; }
        public required string LocalEvento { get; set; }

        public int DuracaoEvento
        {
            get => DataFim.Subtract(DataInicio).Days;
        }

        public double CustoEvento
        {
            get
            {
                double CustoTotalEvento = DuracaoEvento * ValorPorParticipante * QtdParticipantes;
                return CustoTotalEvento;
            }
        }
    }
}
