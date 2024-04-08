using Api_Endereco.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Endereco.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
