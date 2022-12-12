using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace JuanHerrera_ExamenP2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnValoresRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if(v3.IsChecked== true) {
            mensaje.Text = $"Usted ha seleccionado una recarga de {t3.Value} dolares";
        }
        if (v5.IsChecked == true)
        {
            mensaje.Text = $"Usted ha seleccionado una recarga de {t5.Value} dolares";
        }
        if (v10.IsChecked == true)
        {
            mensaje.Text = $"Usted ha seleccionado una recarga de {t10.Value} dolares";
        }

    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        if (v3.IsChecked == true)
        {
            bool answer = await DisplayAlert("Confirmacion", $"Desea Hacer la recarga de {v3.Value}", "Si", "No");
            if (answer)
            {
                await DisplayAlert("Confirmado", "Tu recarga ha sido exitosa", "OK");
            }
        }
        if (v5.IsChecked == true)
        {
            bool answer = await DisplayAlert("Confirmacion", $"Desea Hacer la recarga de {v5.Value}", "Si", "No");
            if (answer)
            {
                await DisplayAlert("Confirmado", "Tu recarga ha sido exitosa", "OK");
            }
        }
        if (v10.IsChecked == true)
        {
            bool answer = await DisplayAlert("Confirmacion", $"Desea Hacer la recarga de {v10.Value}", "Si", "No");
            if (answer)
            {
                await DisplayAlert("Confirmado", "Tu recarga ha sido exitosa", "OK");
            }
        }
       
    }
}

