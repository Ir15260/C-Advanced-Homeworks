//Create class User that will have 3 properties Id, Name, Age.
//Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.

using System.Net;
using Domain.Database;

namespace Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public static List<User> SearchByID(int id, List<User> userList)
        {
            if (id <= 0)
                return new List<User>();

            return userList.Where(u => u.Id == id).ToList();
        }

        public static List<User> SearchByName(string name, List<User> userList)
        {
            if (string.IsNullOrEmpty(name))
                return new List<User>();

            name = name.ToLower();

            return userList.Where(u => u.Name.ToLower() == name).ToList();
        }

        public static List<User> SearchByAge(int age, List<User> userList)
        {
            if (age <= 0)
                return new List<User>();

            return userList.Where(u => u.Age == age).ToList();
        }
    }
}

