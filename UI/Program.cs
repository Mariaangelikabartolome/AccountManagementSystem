using AccountManagementData;
using AccountManagementServices;
using AccountManagementModel;



namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserGetServices getServices = new UserGetServices();


            Console.WriteLine("Active Users:");
            var activeUsers = getServices.GetUsersByStatus(1);
            DisplayUsers(activeUsers);


            Console.WriteLine("\nInactive Users:");
            var inactiveUsers = getServices.GetUsersByStatus(2);
            DisplayUsers(inactiveUsers);
        }

        static void DisplayUsers(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine("Username: " + item.username);
                Console.WriteLine("Password: " + item.password);
                Console.WriteLine("Status: " + item.status);
            }
        }
    }
}
