using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class MetasPage : ContentPage
{
    public MetasPage()
    {
        InitializeComponent();
        Lista.ItemsSource = Dados.Metas;
    }
}
