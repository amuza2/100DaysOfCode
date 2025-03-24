
public class StoryService : IStoryService
{
    private readonly IStoryRepository _storyRepository;
    private Story _currentStory;
    private int _currentPageIndex = 0;

    public StoryService(IStoryRepository storyRepository)
    {
        _storyRepository = storyRepository;
    }

    public int GetTotalPages() => _currentStory?.Pages.Count ?? 0;

    public bool MoveNextPage()
    {
        if(_currentPageIndex < _currentStory.Pages.Count - 1 )
        {
            _currentPageIndex++;
            return true;
        }
        return false;
    }

    public bool MovePreviousPage()
    {
        if(_currentPageIndex > 0)
        {
            _currentPageIndex--;
            return true;
        }
        return false;
    }

    public StoryPage GetCurrentPage()
    {
        return _currentStory?.Pages[_currentPageIndex];
    }

    public void LoadStory(int storyId)
    {
        _currentStory = _storyRepository.GetStoryById(storyId);
        _currentPageIndex = 0;
    }

    public int GetCurrentPageNumber()
    {
        return _currentPageIndex + 1;
    }
    public Story GetCurrentStory()
    {
        return _currentStory;
    }
}