namespace Login1.Page;

public partial class ExibirUsuarioPage : ContentPage
{
	public ExibirUsuarioPage()
	{
		InitializeComponent();

        AtualizaPage();
    }

	private async void AtualizaPage()
	{
		lsvUsuarios.ItemsSource= await App.BancoDados.UsuarioDataTable.ListaUsuarios();
	}

}