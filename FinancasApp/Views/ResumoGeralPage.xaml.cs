using FinancasApp.Data;

namespace FinancasApp.Views;

public partial class ResumoGeralPage : ContentPage
{
    public ResumoGeralPage()
    {
        InitializeComponent();
        ReceitasLabel.Text = Dados.Moeda(Dados.TotalReceitas);
        DespesasLabel.Text = Dados.Moeda(Dados.TotalDespesas);
        SaldoLabel.Text = Dados.Moeda(Dados.Saldo);
    }
}
