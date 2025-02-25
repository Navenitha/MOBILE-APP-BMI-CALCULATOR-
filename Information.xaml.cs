namespace BMICalculator;

public partial class Information : ContentPage
{
	public Information()
	{
		InitializeComponent();
	}


	async void OnYogaClicked(object sender, EventArgs args)
	{

		await Browser.OpenAsync(" https://youtu.be/hJbRpHZr_d0", BrowserLaunchMode.SystemPreferred);

	}

	async void OnGymClicked(object sender, EventArgs args)
	{
		await Launcher.OpenAsync("http://maps.google.com/?daddr=Dewan+Seri+Sarjana");
	}

}