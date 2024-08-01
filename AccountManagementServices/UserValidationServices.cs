using AccountManagementData;

public class UserValidationServices
{
    private UserGetServices getServices;

    public UserValidationServices(UserData userData)
    {
        getServices = new UserGetServices(userData);
    }

    public bool CheckIfUserNameExists(string username)
    {
        bool result = getServices.GetUser(username) != null;
        return result;
    }

    public bool CheckIfUserExists(string username, string password)
    {
        bool result = getServices.GetUser(username, password) != null;
        return result;
    }
}
