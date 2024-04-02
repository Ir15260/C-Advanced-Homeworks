//Create class User that will have 3 properties Id, Name, Age.
//Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list).
//Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result.
using Domain.Database;
using Domain.Models;

Console.WriteLine("Enter a name or ID to search:");
string input = Console.ReadLine();

int id;
bool isNumeric = int.TryParse(input, out id);

List<User> searchResult;

if (isNumeric)
{
    searchResult = User.SearchByID(id, UserDatabase.Users);
}
else 
{
    searchResult = User.SearchByName(input, UserDatabase.Users);
}

if (searchResult.Count > 0)
{
    Console.WriteLine("Search Results:");
    foreach (User user in searchResult)
    {
        Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
    }
}
else
{
    Console.WriteLine("No user found with the provided input.");
}
        