using AccountManagementModel;
namespace AccountManagementData
{
    public class UserData
    {
        List<User> users;
        public UserData()
        {
            users = new List<User>();
            UserFactory _userFactory = new UserFactory();
            users = _userFactory.GetDummyUsers();
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].username == user.username)
                {
                    users[i].profile = user.profile;
                    users[i].username = user.username;
                    users[i].dateUpdated = DateTime.Now;
                }
            }
        }
        public void UpdateUserStatus(string username, int UpdatedStatus)
        {
            foreach (var user in users)
            {
                if (user.username == username)
                {
                    user.status = UpdatedStatus;
                    user.dateUpdated = DateTime.Now;
                }
            }
        }
    }
}