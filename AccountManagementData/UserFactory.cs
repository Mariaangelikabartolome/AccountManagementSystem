using AccountManagementModel;

namespace AccountManagementData
{
    public class UserFactory
    {
        private List<User> dummyUsers = new List<User>();

        public List<User> GetDummyUsers()
        {
            dummyUsers.Add(CreateDummyUser("Admin123!", "Admin", "Admin@pup.com", 1)); 
            dummyUsers.Add(CreateDummyUser("Test123!", "Test", "Test@pup.com", 1));
            dummyUsers.Add(CreateDummyUser("Hello123!", "Hello", "Hello@pup.com", 1));
            dummyUsers.Add(CreateDummyUser("Bye123!", "Bye", "Bye@pup.com", 1)); 
            dummyUsers.Add(CreateDummyUser("Angelikabartolome1005 ", "AngelGanda", "MariaAngelika@gmail.com", 1)); 
            return dummyUsers;
        }

        private User CreateDummyUser(string password, string username, string emailaddress, int status)
        {
            User user = new User
            {
                username = username,
                password = password,
                profile = new UserProfile { emailAddress = emailaddress, profileName = username },
                dateUpdated = DateTime.Now,
                dateVerified = DateTime.Now.AddDays(1),
                status = status
            };

            return user;
        }

    }
}