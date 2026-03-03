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
			TrybAspectu.Text = "Aspect: Fill";

        }
		else if (Gif1.Aspect == Aspect.Fill)
		{
			{
				Gif1.Aspect = Aspect.AspectFill;
				TrybAspectu.Text = "Aspect: AspectFill";
            }
		}
		else if (Gif1.Aspect == Aspect.AspectFill)
		{
			Gif1.Aspect = Aspect.AspectFit;
			TrybAspectu.Text = "Aspect: AspectFit";
        }
	}
}

/*Nazwa:OnButtonClicked 
 * Opis:Sprawdza aktualny tryb wyœwietlania obrazu (Aspect) i zmienia go na kolejny: AspectFit -> Fill -> AspectFill -> AspectFit.
 * parametry: sender - obiekt, który wywo³a³ zdarzenie (przycisk), e - argumenty zdarzenia (nieu¿ywane).
 * zwracany typ:void (nie zwraca ¿adnej wartoœci).
 * autor:Ja
 */