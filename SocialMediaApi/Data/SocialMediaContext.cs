using Microsoft.EntityFrameworkCore;
using SocialMediaApi.Models;

public class SocialMediaContext : DbContext
{
    public SocialMediaContext(DbContextOptions<SocialMediaContext> options) 
        : base(options) 
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }
    public DbSet<Post> Posts { get; set; }

    
}
