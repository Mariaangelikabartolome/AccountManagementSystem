using AccountManagementData;
using AccountManagementModel;

public class UserTransactionServices
{
    UserValidationServices validationServices;
    UserData _userData;

    public UserTransactionServices(UserData userData)
    {
        _userData = userData;
        validationServices = new UserValidationServices(_userData);
    }

    public bool CreateUser(User user)
    {
        bool result = validationServices.CheckIfUserNameExists(user.username);

        if (!result)
        {
            _userData.AddUser(user);
        }

        return !result;
    }

    public bool UpdateUser(User user)
    {
        bool result = validationServices.CheckIfUserNameExists(user.username);

        if (result)
        {
            _userData.UpdateUser(user);
        }

        return result;
    }
}