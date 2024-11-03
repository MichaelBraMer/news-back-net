using Microsoft.EntityFrameworkCore;
using NewsApi.Domain.Entities;

namespace NewsApi.Infrastructure.Data
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options) { }

        public DbSet<News> News { get; set; }
    }
}
