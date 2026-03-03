namespace MAUI20
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var image = new Image
            {
                Source = ImageSource.FromFile("dotnet_bot.png"),
                HeightRequest = 200
            };
            MainStack.Children.Add(image);
            var remoteImage = new Image
            {
                Source = new UriImageSource
                {
                    Uri = new Uri("https://preview.redd.it/monke-image-dump-14-v0-gs8qhluhl3oa1.jpg?width=1080&crop=smart&auto=webp&s=5dcc196eb5779c4b234961aaed01f4c54a994019"),
                    CacheValidity = TimeSpan.FromDays(7)
                },
                HeightRequest = 200,
                Aspect = Aspect.AspectFit
            };
            MainStack.Children.Add(remoteImage);
        }
    }
}
