public interface IStoryService
{
    StoryPage GetCurrentPage();
    bool MoveNextPage();
    bool MovePreviousPage();
    void LoadStory(int storyId);
    int GetCurrentPageNumber();
    int GetTotalPages();
    public Story GetCurrentStory();
}