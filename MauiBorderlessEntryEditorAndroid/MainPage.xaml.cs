namespace MauiBorderlessEntryEditorAndroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ChangeEntryBg();
        }

        private async void ChangeEntryBg()
        {
            await Task.Delay(2000);
            entry.BackgroundColor = Colors.AliceBlue;
            await Task.Delay(3000);
            entry.BackgroundColor = Colors.LightBlue;
            await Task.Delay(4000);
            entry.BackgroundColor = Colors.Teal;
            await Task.Delay(2000);
            entry.BackgroundColor = Colors.LightGoldenrodYellow;
            await Task.Delay(3000);
            entry.BackgroundColor = Colors.White;
        }
    }

}
