namespace MAUI20;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	void OnButtonClicked(object sender, EventArgs e)
	{
		if (Gif1.Aspect == Aspect.AspectFit)
		{
			Gif1.Aspect = Aspect.Fill;

		}
		else if (Gif1.Aspect == Aspect.Fill)
		{
			{
				Gif1.Aspect = Aspect.AspectFill;
			}
		}
		else if (Gif1.Aspect == Aspect.AspectFill)
		{
			Gif1.Aspect = Aspect.AspectFit;
		}
	}
}