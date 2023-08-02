namespace Login1.Page;

public partial class HomePrincipalPage : TabbedPage
{
	public HomePrincipalPage()
	{
		InitializeComponent();

		var pagina1 = new ListaFeedPage()
		{
			Title = "Feed"
			
		};

        var pagina2 = new ExibirUsuarioPage()
        {
            Title = "Exibir Usuario"
            
        };
        var pagina3 = new BuscaUsuarioPage()
        {
            Title = "Buscar Usuario"
            
        };

        this.Children.Add(pagina1);
        this.Children.Add(pagina2);
        this.Children.Add(pagina3);
    }
}