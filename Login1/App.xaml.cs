using Login1.Data;
using Login1.Model;
using Login1.Page;

namespace Login1;

public partial class App : Application
{

	static SQLiteData _bancoDatos;

	public static SQLiteData BancoDados
	{
		get
		{
			if( _bancoDatos == null)
			{
				_bancoDatos =
					new SQLiteData(DependencyService
					.Get<ISQLiteBD>()
					.SQLiteLocalPath("Dados.db3"));
			}
			return _bancoDatos;
		}
	}

	public static Usuario Usuario { get; set; }


	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage (new LoginUsuario());
	}
}
