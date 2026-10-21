using Microsoft.EntityFrameworkCore;
using PortfolioProject.Entities;

namespace PortfolioProject.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\TWildrunner;Database=DbPortfolioProject;Integrated Security=true;trust Server Certificate= true");
        }

        public DbSet<Experience> Experiences { get; set; }

        public DbSet<HeroTitle> HeroTitles { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<HeroSection> HeroSections { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SkillItem> SkillItems { get; set; }
    }
}
