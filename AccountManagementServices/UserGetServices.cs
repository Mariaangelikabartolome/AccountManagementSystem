using AccountManagementData;
using AccountManagementModel;

public class UserGetServices
{
    private UserData _userData;

    public UserGetServices(UserData userData)
    {
        _userData = userData;
    }

    public List<User> GetUsersByStatus(int userStatus)
    {
        List<User> usersByStatus = new List<User>();
        foreach (var user in _userData.GetUsers())
        {
            if (user.status == userStatus)
            {
                usersByStatus.Add(user);
            }
        }
        return usersByStatus;
    }

    public User GetUser(string username, string password)
    {
        foreach (var user in _userData.GetUsers())
        {
            if (user.username == username && user.password == password)
            {
                return user;
            }
        }
        return null;
    }

    public User GetUser(string username)
    {
        foreach (var user in _userData.GetUsers())
        {
            if (user.username == username)
            {
                return user;
            }
        }
        return null;
    }
}
