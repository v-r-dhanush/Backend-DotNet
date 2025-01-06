using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTask
{
    internal class DelegateAndEvent
    {
        // Declare a delegate for the event
        public delegate void BannedUserEventHandler(string userName);

        // Declare an event based on the delegate
        public static event BannedUserEventHandler OnBannedUser;

        static void Main(string[] args)
        {
            // Subscribe to the event
            OnBannedUser += HandleBannedUser;

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // Check if the user is banned
            if (IsBannedUser(userName))
            {
                // Raise the event if the user is banned
                OnBannedUser?.Invoke(userName);
            }
            else
            {
                Console.WriteLine($"Welcome {userName} to Changepond");
            }
        }

        // Method to check if a user is banned
        static bool IsBannedUser(string name)
        {
            string[] bannedUsers = { "Jack", "Steven", "Mathew" };
            return Array.Exists(bannedUsers, banned => banned.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Event handler for banned users
        static void HandleBannedUser(string userName)
        {
            Console.WriteLine($"Alert! {userName} is a banned user.");

            // Simulate firing an alarm (this could be replaced with actual alarm logic)
            Console.WriteLine("Firing alarm...");
        }
    }
}
