namespace FinancasApp.Views;

public partial class PerfilPage : ContentPage
{
    public PerfilPage()
    {
        InitializeComponent();
    }

    private async void OnEditarClicked(object? sender, EventArgs e)
        => await DisplayAlertAsync("Perfil", "Tela de edição ainda não implementada (apenas ilustrativa).", "OK");
}
