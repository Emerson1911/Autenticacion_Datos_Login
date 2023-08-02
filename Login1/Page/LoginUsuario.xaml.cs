namespace Login1.Page;

public partial class LoginUsuario : ContentPage
{
	public LoginUsuario()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EditaUsuarioPage());
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if(!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email,senha);   
            if(usuario != null)
            {
                await DisplayAlert("Atencao", "E-mail ou senha invalidos", "Fechar");
                return;
            }

            App.Usuario = usuario;

             Navigation.PushAsync(new HomePrincipalPage());
        }
    }
}