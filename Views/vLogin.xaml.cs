namespace ctrujilloExamen.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private Dictionary<string, string> users = new()
    {
        { "estudiante2025", "moviles" },
        { "uisrael", "2025" },
        { "sistemas", "2025_1" }
    };

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string clave = txtContraseña.Text;

        if (users.ContainsKey(usuario) && users[usuario] == clave)
        {
            Navigation.PushAsync(new Views.vRegistro(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
    private void btnAcercaDe_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.vAcercaDe(txtUsuario.Text));
    }
}