
using Microsoft.EntityFrameworkCore;
using ProjetoConcessionaria.Lib.Models;

namespace ProjetoConcessionaria.Lib.Data
{
    public class ConcessionariaContext : DbContext
    {
        public ConcessionariaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }
    }
}