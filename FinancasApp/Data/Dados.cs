using System.Globalization;
using FinancasApp.Models;

namespace FinancasApp.Data;

// Dados fictícios só para ilustrar as telas (não há banco nem API).
public static class Dados
{
    private static readonly CultureInfo Br = new("pt-BR");

    public static List<Transacao> Transacoes { get; } = new()
    {
        new() { Descricao = "Salário", Categoria = "Renda", Valor =  4500m, Data = new DateTime(2026, 11, 5)  },
        new() { Descricao = "Freelance", Categoria = "Renda extra", Valor =   800m, Data = new DateTime(2026, 11, 12) },
        new() { Descricao = "Aluguel", Categoria = "Moradia", Valor = -1400m, Data = new DateTime(2026, 11, 6)  },
        new() { Descricao = "Supermercado", Categoria = "Alimentação", Valor =  -620m, Data = new DateTime(2026, 11, 9)  },
        new() { Descricao = "Transporte", Categoria = "Mobilidade", Valor =  -210m, Data = new DateTime(2026, 11, 10) },
        new() { Descricao = "Internet", Categoria = "Moradia", Valor =   -99m, Data = new DateTime(2026, 11, 15) },
        new() { Descricao = "Cinema", Categoria = "Lazer", Valor =   -60m, Data = new DateTime(2026, 11, 18) },
        new() { Descricao = "Farmácia", Categoria = "Saúde", Valor =   -85m, Data = new DateTime(2026, 11, 20) },
    };

    public static List<Meta> Metas { get; } = new()
    {
        new() { Nome = "Reserva de emergência", Atual = 6200m, Alvo = 15000m },
        new() { Nome = "Viagem de fim de ano", Atual = 2100m, Alvo = 3500m  },
        new() { Nome = "Notebook novo", Atual =  900m, Alvo = 4000m  },
    };

    public static IEnumerable<Transacao> Despesas => Transacoes.Where(t => !t.EhReceita);
    public static IEnumerable<Transacao> Receitas => Transacoes.Where(t => t.EhReceita);

    public static decimal TotalReceitas => Receitas.Sum(t => t.Valor);
    public static decimal TotalDespesas => Despesas.Sum(t => Math.Abs(t.Valor));
    public static decimal Saldo => TotalReceitas - TotalDespesas;

    public static string Moeda(decimal v) => v.ToString("C2", Br);
}
