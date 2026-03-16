using lab1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<Photograph> Photos { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<MyUser> MyUsers { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}
