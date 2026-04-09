using System;

namespace MAUI20;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
		string[] linki = new string[] {
            "https://preview.redd.it/monke-image-dump-14-v0-gs8qhluhl3oa1.jpg?width=1080&crop=smart&auto=webp&s=5dcc196eb5779c4b234961aaed01f4c54a994019",
            "https://i.pinimg.com/originals/31/a7/2a/31a72afda250825d993400c3ef28c55c.gif",
            "https://media.tenor.com/WpXHQc0sNHgAAAAM/mikrocypek-actimel.gif",
            "https://media.tenor.com/BNby1AnlynMAAAAM/spinning-spining-cat.gif"};

        for(int i=0; i < linki.Length; i++)
        {
            var image = new Image 
            {
                Source = new UriImageSource
                {
                    Uri = new Uri(linki[i]),
                    CacheValidity = TimeSpan.FromDays(3)
                }, 
              Aspect = Aspect.AspectFit, 
              HeightRequest = 200 };

            var frame = new Frame
            {
                Content = image,
                CornerRadius = 15,
                BorderColor = Microsoft.Maui.Graphics.Colors.Yellow,
                Margin = new Thickness(0, 0, 0, 3)
            };

            var label = new Label { Text = $"Obrazek {i + 1}", FontSize = 18, HorizontalOptions = LayoutOptions.Center };

            int numer = i;
            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += async (s, e) =>
            {
                await DisplayAlert("Obrazek", $"Wybrano obrazek {numer + 1}", "OK");
            };
            frame.GestureRecognizers.Add(tapGesture);

            MainStack.Children.Add(frame);
            MainStack.Children.Add(label);
        }

    }
}