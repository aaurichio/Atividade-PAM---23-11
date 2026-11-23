using System.Globalization;

namespace FinancasApp.Models;

public class Meta
{
    public string Nome { get; set; } = "";
    public decimal Atual { get; set; }
    public decimal Alvo { get; set; }
    public double Progresso => Alvo == 0 ? 0 : (double)(Atual / Alvo);
    public string Texto => $"{Atual.ToString("C0")} de {Alvo.ToString("C0")} ({Progresso:P0})";
}
