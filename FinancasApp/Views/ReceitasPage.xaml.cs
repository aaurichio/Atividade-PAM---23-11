using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class ReceitasPage : ContentPage
{
    public ReceitasPage()
    {
        InitializeComponent();
        Lista.ItemsSource = Dados.Receitas.OrderByDescending(t => t.Data).ToList();
    }
}
