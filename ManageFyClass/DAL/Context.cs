using ManageFyClass.DAL.DAO;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace ManageFyClass.DAL
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Conta> Contas { get; set; }

        private string strConn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ManageFy;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
            "Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(strConn)
                .UseLazyLoadingProxies();
        }
    }
}
