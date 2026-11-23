using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();

        SaldoLabel.Text = Dados.Moeda(Dados.Saldo);
        ResumoLabel.Text = $"Receitas {Dados.Moeda(Dados.TotalReceitas)}  •  Despesas {Dados.Moeda(Dados.TotalDespesas)}";
    }

    // O CommandParameter de cada card guarda o nome da rota a abrir
    private async void OnCardTapped(object? sender, TappedEventArgs e)
    {
        if (e.Parameter is string rota)
            await Shell.Current.GoToAsync(rota);
    }
}
