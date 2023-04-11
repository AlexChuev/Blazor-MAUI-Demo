namespace BlazorDemo.MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {

        }

        private void blazorWebView_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine(blazorWebView.Height);
        }
    }
}