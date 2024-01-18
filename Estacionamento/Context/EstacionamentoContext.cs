using Estacionamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Context
{
    public class EstacionamentoContext : DbContext
    {
        public EstacionamentoContext(DbContextOptions<EstacionamentoContext> options) : base(options)
        {

        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
