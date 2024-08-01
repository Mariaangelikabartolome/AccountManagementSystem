using AccountManagementData;
using AccountManagementModel;


namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserData userData = new UserData();
            UserGetServices getServices = new UserGetServices(userData);
            UserTransactionServices transactionServices = new UserTransactionServices(userData);

            // Add new users
            AddUsers(transactionServices);

            // To display old list of active status + the added users
            Console.WriteLine("Old List of Active Users:");
            var activeUsers = getServices.GetUsersByStatus(1);
            DisplayUsers(activeUsers);

            // Updated some of the user status
            UpdateUserStatus(userData, "Test", 2);
            UpdateUserStatus(userData, "Admin", 2);

            //To Display new and updated active users
            Console.WriteLine("\nUpdated Active Users:");
            activeUsers = getServices.GetUsersByStatus(1);
            DisplayUsers(activeUsers);

            // Display inactive users
            Console.WriteLine("\nInactive Users:");
            var inactiveUsers = getServices.GetUsersByStatus(2);
            DisplayUsers(inactiveUsers);


        }

        static void AddUsers(UserTransactionServices transactionServices)
        {
            User AddedUser1 = new User
            {
                username = "AngelikaCutie",
                password = "AngelKyuti",
                profile = new UserProfile { emailAddress = "Angelbartolome@gmail.com", profileName = "user" },
                status = 1
            };
            User AddedUser2 = new User
            {
                username = "Mariae",
                password = "MariaAngelika",
                profile = new UserProfile { emailAddress = "Mariae1005@gmail.com", profileName = "user2" },
                status = 1
            };

            transactionServices.CreateUser(AddedUser1);
            transactionServices.CreateUser(AddedUser2);
        }

        static void UpdateUserStatus(UserData userData, string username, int newStatus)
        {
            userData.UpdateUserStatus(username, newStatus);


        }

        static void DisplayUsers(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine("Username: " + item.username);
                Console.WriteLine("Status: " + item.status);

            }
        }
    }
}