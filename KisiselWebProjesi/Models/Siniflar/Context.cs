using System.Data.Entity;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<ikonlar> ikonlars { get; set; }
    }
}