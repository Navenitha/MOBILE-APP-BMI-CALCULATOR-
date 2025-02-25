
namespace BMICalculator;

public partial class Record : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    //string fileName= Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMIRecord.txt");

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        displayRecord.ItemsSource = await firebaseHelper.GetAllBmiRecord();
    }

    public Record()
    {
        InitializeComponent();
        //displayRecord.Text = File.ReadAllText(fileName);
    }
}
