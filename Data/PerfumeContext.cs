using Microsoft.EntityFrameworkCore;
using Perfume.Models;

namespace Perfume.Data
{
    public class PerfumeContext : DbContext
    {
        public PerfumeContext(DbContextOptions<PerfumeContext> opt) : base(opt)
        {
            
        }

        //Representação da classe model Perfume no DB
        public DbSet<PerfumeModel> Perfumes { get; set; }
    }
}