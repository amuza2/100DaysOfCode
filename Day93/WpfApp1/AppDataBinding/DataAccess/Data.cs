using AppDataBinding.Model;
using System.Collections.ObjectModel;

namespace AppDataBinding;

public class Data
{
    private static ObservableCollection<User> _users = new ObservableCollection<User>
    {
        new User { Id = 1, Name = "John Doe", Email = "John Doe" },
            new User { Id = 2, Name = "Jane Doe", Email = "Jane Doe" },
            new User { Id = 3, Name = "Sammy Doe", Email = "Sammy Doe" },
            new User { Id = 4, Name = "Sam Doe", Email = "Sam Doe" }
    };

    public static ObservableCollection<User> GetUsers()
    {
        return _users;
    }

    public static int AddUser(User user)
    {
        int maxId = _users.Max(x => x.Id);
        user.Id = maxId + 1;
        _users.Add(user);
        return user.Id;
    }
}
