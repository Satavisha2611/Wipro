using Microsoft.EntityFrameworkCore;

public class AppDBContext : DbContext
{
    public DbSet<User> Users {get; set;}//Database set to store users according to class user

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source = app.db");
}