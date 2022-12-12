using System.Diagnostics;

namespace JuanHerrera_ExamenP2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void OnValoresRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Label label = new Label { Text = "Usted ha ecogido una recarga de " + e.ToString() + " dolares"};
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Confirmacion", "Desea Hacer la recarga?", "Si", "No");
        if (answer)
        {
            await DisplayAlert("Confirmado", "Tu recarga ha sido exitosa", "OK");
        }
    }
}

