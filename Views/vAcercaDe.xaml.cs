namespace ctrujilloExamen.Views;

public partial class vAcercaDe : ContentPage
{
    private Dictionary<string, string> usuarios = new()
    {
        { "estudiante2025", "moviles" },
        { "uisrael", "2025" },
        { "sistemas", "2025_1" }
    };
    public vAcercaDe(string usuario)
	{
		InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {usuario}";
        lblClave.Text = usuarios.ContainsKey(usuario)
            ? $"Contrase�a: {usuarios[usuario]}"
            : "Contrase�a: [No registrada]";
    }
}