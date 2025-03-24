using System.Windows.Input;

namespace KidStoryAppProject
{
    public partial class MainPage : ContentPage
    {
        public Command<StoryCard> ReadStoryCommand { get; }
        public ICommand ListenStoryCommand { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ReadStoryCommand = new Command<StoryCard>(OnReadStoryClicked);
            ListenStoryCommand = new Command<StoryCard>(OnListenStoryClicked);
            LoadStories();
        }

        private async void OnListenStoryClicked(StoryCard card)
        {
            await DisplayAlert("ميزة قارئ الصوت","قادمة قريبا إن شاء الله", "حسننا");
        }

        private void LoadStories()
        {
            try
            {
                var storyCards = new List<StoryCard>
                {
                    new StoryCard
                    {
                        Id = 1,
                        Title = "الأرنب و السلحفات",
                        Description = "تعلم المثابرة",
                        CoverImage = "aa.png"
                    },
                    new StoryCard
                    {
                        Id = 2,
                        Title = "ليلى و الذئب",
                        Description = "خذ بالنصيحة و لا تتجاهلها",
                        CoverImage = "s2a.png"
                    },
                    new StoryCard
                    {
                        Id = 3,
                        Title = "النملة و الصرصور",
                        Description = "تعلم أن الكسل لا يفيد",
                        CoverImage = "s3a.png"
                    },
                };

                storiesCollection.ItemsSource = storyCards;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading stories: {ex.Message}");
            }
        }

        private async void OnReadStoryClicked(StoryCard selectedStory)
        {
            try
        {
            Console.WriteLine($"Reading story: {selectedStory.Title}");

            // Create services
            var storyService = new StoryService(new ArabicStoryRepository());
            var textToSpeechService = new TextToSpeechService();

            // Create and navigate to story page
            var storyPage = new Story1(selectedStory.Id, storyService, textToSpeechService);
            await Navigation.PushAsync(storyPage);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Failed to load story: {ex.Message}", "OK");
        }
        }
        
    }

}
