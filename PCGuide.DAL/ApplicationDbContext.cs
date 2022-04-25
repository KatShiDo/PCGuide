using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCGuide.Domain.Entities;

namespace PCGuide.DAL
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<CPUCooler> CPUCoolers { get; set; }
        public DbSet<Frame> Frames { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<HardDrive> HardDrives { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerUnit> PowerUnits { get; set; }
        public DbSet<RAM> RAM { get; set; }
        public DbSet<SSD> SSDs { get; set; }
        //public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "F83A39C9-6960-4934-8CDC-88D0AAB64AAF",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "F113EC5E-FC39-41CD-8CD7-046E521C9A4C",
                UserId = "F83A39C9-6960-4934-8CDC-88D0AAB64AAF"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("5496D893-FFEA-40A6-8DE4-FE8C643FC041"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("38157BF9-102B-421A-A206-80828157CCEC"),
                CodeWord = "PageCatalog",
                Title = "Каталог"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("69B8DE34-9245-49A1-B3A7-CAD861A2DD05"),
                CodeWord = "PageNews",
                Title = "Новости"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("EBAA3373-F6AC-4EF8-A7EC-DAAB4F4FE3A9"),
                CodeWord = "PageFeedback",
                Title = "Обратная связь"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = new System.Guid("62B29DC5-9279-432B-B0F5-004042B5EDCC"),
                CodeWord = "PageCompany",
                Title = "О компании"
            });
        }
    }
}
