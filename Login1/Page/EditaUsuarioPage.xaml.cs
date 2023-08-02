using Login1.Model;

namespace Login1.Page;

public partial class EditaUsuarioPage : ContentPage
{
	Usuario _usuario;
	public EditaUsuarioPage()
	{
		InitializeComponent();
		_usuario= new Usuario();


		this.BindingContext = _usuario;
	}

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
		if(string.IsNullOrWhiteSpace(_usuario.Email) &&
			string.IsNullOrWhiteSpace(_usuario.Senha))
		{
			await DisplayAlert("Atencao", "Preencha todas as informacoes", "Fechar");
			return;
		}

		var cadastro = await App.BancoDados.UsuarioDataTable.SalvaUsuario(_usuario);

		if(cadastro > 0 )
		{
			await Navigation.PopAsync();
		}
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}