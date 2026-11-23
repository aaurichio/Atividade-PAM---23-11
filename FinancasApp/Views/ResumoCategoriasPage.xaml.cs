using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class ResumoCategoriasPage : ContentPage
{
    public ResumoCategoriasPage()
    {
        InitializeComponent();

        var porCategoria = Dados.Despesas
            .GroupBy(t => t.Categoria)
            .Select(g => new { Categoria = g.Key, Total = g.Sum(t => Math.Abs(t.Valor)) })
            .OrderByDescending(x => x.Total);

        foreach (var item in porCategoria)
        {
            var linha = new Grid { ColumnDefinitions = { new ColumnDefinition(GridLength.Star), new ColumnDefinition(GridLength.Auto) } };
            linha.Add(new Label { Text = item.Categoria });
            linha.Add(new Label { Text = Dados.Moeda(item.Total), FontAttributes = FontAttributes.Bold }, 1, 0);

            Container.Add(new Border
            {
                Style = (Style)Application.Current!.Resources["CardBorder"],
                Content = linha
            });
        }
    }
}
