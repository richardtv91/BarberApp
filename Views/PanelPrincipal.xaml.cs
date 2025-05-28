using BarberApp.Models;

namespace BarberApp.Views;

public partial class PanelPrincipal : ContentPage
{
	public PanelPrincipal(Persona datos)
	{
		InitializeComponent();
        CargarResumenDelDia();
        lblUsuario.Text += $"({datos.Nombres})";
    }
    private async void CargarResumenDelDia()
    {
        
        
    }
    private async void OnRegistrarCorteClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrarCortePage());
    }

    // Evento cuando el barbero hace clic en "Historial de Servicios"
    private async void OnHistorialClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistorialPage());
    }
}