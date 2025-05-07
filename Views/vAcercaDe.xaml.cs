namespace ctrujilloExamen.Views;

public partial class vAcercaDe : ContentPage
{
    private Dictionary<string, string> users = new()
    {
        { "estudiante2025", "moviles" },
        { "uisrael", "2025" },
        { "sistemas", "2025_1" }
    };
    public vAcercaDe(string usuario)
	{
		InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {usuario}";
        lblClave.Text = users.ContainsKey(usuario)
            ? $"Contraseña: {users[usuario]}"
            : "Contraseña: [No registrada]";
    }
}