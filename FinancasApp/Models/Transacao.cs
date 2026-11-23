using System.Globalization;

namespace FinancasApp.Models;

public class Transacao
{
    public string Descricao { get; set; } = "";
    public string Categoria { get; set; } = "";
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public bool EhReceita => Valor > 0;
    public string ValorFormatado => Valor.ToString("C2");
    public string DataFormatada => Data.ToString("dd/MM/yyyy");
    public Color Cor => EhReceita ? Color.FromArgb("#16A34A") : Color.FromArgb("#DC2626");
}
