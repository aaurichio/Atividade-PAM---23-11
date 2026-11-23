using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class DespesasPage : ContentPage
{
    public DespesasPage()
    {
        InitializeComponent();
        Lista.ItemsSource = Dados.Despesas.OrderByDescending(t => t.Data).ToList();
    }
}
