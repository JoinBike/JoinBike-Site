using JoinBike_Site.Models;
using Microsoft.EntityFrameworkCore;

namespace JoinBike_SITE.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<UsuarioModel> Usuario { get; set; }
    }
}
