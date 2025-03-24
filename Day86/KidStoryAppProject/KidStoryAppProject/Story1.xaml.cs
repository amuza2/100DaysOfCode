
namespace KidStoryAppProject;

public partial class Story1 : ContentPage
{
    private readonly IStoryService _storyService;
    private readonly ITextToSpeechService _textToSpeechService;
    private CancellationTokenSource _speechCancellation;
	
	public Story1(int storyId, IStoryService storyService, ITextToSpeechService textToSpeechService)
	{
        try
        {
		    InitializeComponent();
            _storyService = storyService ?? throw new ArgumentNullException(nameof(storyService));
            _textToSpeechService = textToSpeechService ?? throw new ArgumentNullException(nameof(textToSpeechService));
            _storyService.LoadStory(storyId);
            LoadCurrentPage();
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", $"Failed to load story: {ex.Message}", "OK");
        }
    }
    private void LoadCurrentPage()
    {
        try
        {
            var page = _storyService.GetCurrentPage();
            if(page != null)
            {
                Title = _storyService.GetCurrentStory().Title;
                lblStoryTitle.Text = $" صفحة {_storyService.GetCurrentPageNumber()} من {_storyService.GetTotalPages()}";
                lblStoryText.Text = page.Content;
                img.Source = page.ImagePath;
            }
            else
            {
                Console.WriteLine("No page content available");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading page content: {ex}");
        }
    }
    
    private async void btnSpeaker_Clicked(object sender, EventArgs e)
    {
        _speechCancellation?.Cancel();
        _speechCancellation = new CancellationTokenSource();

        try
        {
            var page = _storyService.GetCurrentPage();
            await _textToSpeechService.SpeakAsync(
                page.Content,
                _speechCancellation.Token
            );
        }
        catch (OperationCanceledException)
        {
            
        }
    }
    private void BeforeButton_Clicked(object sender, EventArgs e)
    {
        if(_storyService.MovePreviousPage())
        {
            _speechCancellation?.Cancel();
            LoadCurrentPage();
        }
    }
    private void NextButton_Clicked(object sender, EventArgs e)
    {
        if(_storyService.MoveNextPage())
        {
            _speechCancellation?.Cancel();
            LoadCurrentPage();
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _speechCancellation?.Cancel();
    }










}