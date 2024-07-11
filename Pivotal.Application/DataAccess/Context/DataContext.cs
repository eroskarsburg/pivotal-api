using Microsoft.EntityFrameworkCore;
using Pivotal.Domain.Entities;

namespace Pivotal.Application.DataAccess.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
