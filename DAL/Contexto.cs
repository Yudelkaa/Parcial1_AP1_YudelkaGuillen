using Microsoft.EntityFrameworkCore;
using Parcial1_AP1_YudelkaGuillen.Models;

namespace Parcial1_AP1_YudelkaGuillen.Context
{
    public class Contexto: DbContext
    {
        public DbSet<metas> Metas { get; set; }
        public Contexto(DbContextOptions<Contexto> Options):base (Options) { }
    }
}
