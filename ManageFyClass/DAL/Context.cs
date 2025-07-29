using Microsoft.EntityFrameworkCore;

namespace ManageFyClass.DAL
{
    public class Context : DbContext
    {
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
