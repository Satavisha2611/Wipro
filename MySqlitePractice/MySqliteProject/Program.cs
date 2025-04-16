using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] para)
    {
        using var context = new AppDBContext();
        context.Database.EnsureCreated();

        // context.Users.Add(new User{userName = "Satavisha"});
        // context.SaveChanges();

        Console.WriteLine("Enter your name :");
        StringBuilder name = new StringBuilder(Console.ReadLine());
        context.Users.Add(new User{userName=name.ToString()});
        context.SaveChanges();

        var users = context.Users.ToList();
        foreach(var user in users)
        {
            Console.WriteLine($"User ID : {user.userId},  User Name : {user.userName}");
        }
    }
}