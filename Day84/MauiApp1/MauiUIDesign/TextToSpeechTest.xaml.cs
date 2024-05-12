using System.Collections;
using System.Speech.Synthesis;
namespace MauiUIDesign;

public partial class TextToSpeechTest : ContentPage
{
    Locale arabicLang;

    public TextToSpeechTest()
	{
		InitializeComponent();
	}
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        IEnumerable<Locale> locals = await TextToSpeech.GetLocalesAsync();
        arabicLang = locals.Single(l => l.Name == "Arabic");
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await TextToSpeech.Default.SpeakAsync("أهلا و سهلا محمد شامي", new SpeechOptions
		{
			Locale = arabicLang
		}) ;
    }
}