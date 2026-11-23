namespace FinancasApp.Views;

public partial class ConfiguracoesPage : ContentPage
{
    public ConfiguracoesPage()
    {
        InitializeComponent();
    }

    private void OnTemaToggled(object? sender, ToggledEventArgs e)
    {
        if (Application.Current is not null)
            Application.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
    }
}
