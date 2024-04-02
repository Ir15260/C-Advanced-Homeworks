//Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list).
using Domain.Models;


namespace Domain.Database
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; }

        static UserDatabase()
        {
            Users = new List<User>()
            {
                new User(12, "Bob", 33),
                new User(13, "John", 36),
                new User(14, "Alice", 28),
                new User(15, "Emily", 40),
                new User(16, "David", 25),
                new User(17, "Sarah", 31),
                new User(18, "Michael", 45),
                new User(19, "Emma", 22),
                new User(20, "James", 39),
                new User(21, "Olivia", 27),
                new User(22, "William", 34),
                new User(23, "Sophia", 37),
                new User(24, "Ethan", 29),
                new User(25, "Ava", 32),
                new User(26, "Matthew", 41),
                new User(27, "Isabella", 26),
                new User(28, "Daniel", 38),
            };
        }
    }
}