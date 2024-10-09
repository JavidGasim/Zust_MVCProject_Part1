using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zust.Entities.Entities;

namespace Zust.DataAccess.Data
{
    public class ZustDbContext : IdentityDbContext<CustomIdentityUser, CustomIdentityRole, string>
    {
        public ZustDbContext(DbContextOptions<ZustDbContext> options) : base(options)
        {

        }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<LikedPost> LikedPosts { get; set; }
        public DbSet<LikedComment> LikedComments { get; set; }
        public DbSet<MyNotification> MyNotifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ZustDB;Integrated Security=True;", b => b.MigrationsAssembly("Zust.WebUI"));
        }
    }
}
