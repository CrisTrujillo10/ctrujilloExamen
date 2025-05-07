namespace ctrujilloExamen.Views;

public partial class vResumen : ContentPage
{
	public vResumen(string usuario, string nombre, string apellido, 
        string ciudad, DateTime fecha, string va, string inicial, string cuota)
	{
		InitializeComponent();

        lblUsuario.Text = $"Usuario: {usuario}";
        lblNombreCompleto.Text = $"Nombre completo: {nombre} {apellido}";
        lblCiudad.Text = $"Ciudad: {ciudad}";
        lblFecha.Text = $"Fecha: {fecha:yyyy/MM/dd}";
        lblVA.Text = $"Voltiamperio: {va} VA";
        lblMontoInicial.Text = $"Monto inicial: ${inicial}";
        lblCuotaMensual.Text = $"Pago mensual: ${cuota}";
    }


}