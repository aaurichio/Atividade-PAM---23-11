using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class TransacoesPage : ContentPage
{
    public TransacoesPage()
    {
        InitializeComponent();
        Lista.ItemsSource = Dados.Transacoes.OrderByDescending(t => t.Data).ToList();
    }
}
