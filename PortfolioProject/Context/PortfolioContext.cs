using Microsoft.EntityFrameworkCore;
using PortfolioProject.Entities;

namespace PortfolioProject.Context
{
    public class PortfolioContext : DbContext
    {
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<HeroTitle> HeroTitles { get; set; }

        public DbSet<Message> Messages { get; set; }

        public DbSet<HeroSection> HeroSections { get; set; }

    }
}
