using AccountManagementData;
using AccountManagementModel;
namespace AccountManagementServices
{
    public class UserGetServices
    {
        private List<User> GetAllUsers()
        {
            UserData userData = new UserData();
            return userData.GetUsers();
        }

        public List<User> GetUsersByStatus(int userStatus)
        {
            List<User> usersByStatus = new List<User>();
            foreach (var user in GetAllUsers())
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
            foreach (var user in GetAllUsers())
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
            foreach (var user in GetAllUsers())
            {
                if (user.username == username)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
