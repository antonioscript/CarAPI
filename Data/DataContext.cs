using Microsoft.EntityFrameworkCore;
using CarAPI.Models;

namespace CarAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Dizendo ao banco de dados quais são as tabelas a serem criadas
        public DbSet<Car> Cars { get; set; }
    }
}