namespace FinancasApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    // Sem tela de login: o app abre direto no Shell (menu flyout + abas de rodapé).
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
