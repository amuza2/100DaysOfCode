public interface IStoryRepository
{
    Story GetStoryById(int id);
    List<Story> GetAllStories();
}