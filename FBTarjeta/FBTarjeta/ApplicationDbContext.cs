using FBTarjeta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBTarjeta
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QERHAT3\\SQLEXPRESS;Initial Catalog=TarjetaCreditoDB; Trusted_Connection=true;");
            }
        }
    }
}
