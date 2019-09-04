using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
 
namespace SoundBag.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users {get;set;} // Notice "<User>" reffers to the Model (i.e. Models/User.cs) but "user" reffers to the table name
        public DbSet<Festival> festivals {get;set;}
        public DbSet<Association> associations {get;set;}
        public DbSet<Association2> association2 {get;set;}
        public DbSet<Post> posts {get;set;}
    }
}
