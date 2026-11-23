using FinancasApp.Views;

namespace FinancasApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Páginas abertas pelos cards da Home (navegação em pilha, com botão voltar)
        Routing.RegisterRoute("despesas", typeof(DespesasPage));
        Routing.RegisterRoute("receitas", typeof(ReceitasPage));
        Routing.RegisterRoute("resumo",   typeof(ResumoTabbedPage));
        Routing.RegisterRoute("dicas",    typeof(DicasPage));
    }
}
