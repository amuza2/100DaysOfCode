public class Story
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<StoryPage> Pages { get; set; } = new();
}

