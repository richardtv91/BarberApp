using BarberApp.Models;
//using BarberApp.Services;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Text;
namespace BarberApp.Views;

public partial class LoginPage : ContentPage
{
    private readonly HttpClient _httpClient;
    public LoginPage()
	{
		InitializeComponent();
        _httpClient = new HttpClient();
    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var password = txtPassword.Text;
        var email = txtUserM.Text;
        var loginData= new
        {
            email_user = email,
            password = password
        };
        var json=JsonConvert.SerializeObject(loginData);    
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("https://credp-s.net.ec/apiba.php?table=persona&action=login", content);
        if (response.IsSuccessStatusCode)
        {
            var responseData = await response.Content.ReadAsStringAsync();
            var persona = JsonConvert.DeserializeObject<Persona>(responseData);
            // Aquí puedes guardar el token o realizar otras acciones necesarias
            await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");
            // Navegar a la página principal o realizar otra acción
        }
        else
        {
            await DisplayAlert("Error", "Credenciales inválidas", "OK");
        }

    }

}