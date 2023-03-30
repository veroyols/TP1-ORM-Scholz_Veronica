using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    internal class AppDbContext : DbContext
    {
        public DbSet<TipoMercaderia> TipoMercaderiaDb { get; set; }
        public DbSet<FormaEntrega> FormaEntregaDb { get; set; }
        public DbSet<Comanda> ComandaDb { get; set; }
        public DbSet<Mercaderia> MercaderiaDb { get; set; }
        public DbSet<ComandaMercaderia> ComandaMercaderiaDb { get; set; }
        
        //CONECTION STRING
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TP1_VeronicaScholz;Trusted_Connection=True;");
        }

        //MODELADO -> FluentApi
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TIPOMERCADERIA
            modelBuilder.Entity<TipoMercaderia>(entity =>
            {
                entity.ToTable("TipoMercaderia");
                entity.HasKey(c => c.TipoMercaderiaId);
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 1, Descripcion = "Entrada" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 2, Descripcion = "Minutas" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 3, Descripcion = "Pastas" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 4, Descripcion = "Parrilla" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 5, Descripcion = "Pizzas" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 6, Descripcion = "Sandwich" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 7, Descripcion = "Ensaladas" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 8, Descripcion = "Bebidas" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 9, Descripcion = "Cerveza Artesanal" });
                entity.HasData(new TipoMercaderia { TipoMercaderiaId = 10, Descripcion = "Postres" });

                //RELACION: 0 a muchos con Mercaderia

            });

            //FORMAENTREGA
            modelBuilder.Entity<FormaEntrega>(entity =>
            {
                entity.ToTable("FormaEntrega");
                entity.HasKey(c => c.FormaEntregaId);
                entity.HasData(new FormaEntrega { FormaEntregaId = 1, Descripcion = "Salon" });
                entity.HasData(new FormaEntrega { FormaEntregaId = 2, Descripcion = "Delivery" });
                entity.HasData(new FormaEntrega { FormaEntregaId = 3, Descripcion = "Pedidos Ya" });

                //RELACION: 0 a muchos con Comanda

            });

            //MERCADERIA
            modelBuilder.Entity<Mercaderia>(entity =>
            {
                entity.ToTable("Mercaderia");
                entity.HasKey(c => c.MercaderiaId);
                entity.HasData(new Mercaderia {
                    MercaderiaId = 1, 
                    Nombre = "Plato1",
                    TipoMercaderiaId = 1,
                    Precio = 100,
                    Ingredientes = "ingredientes",
                    Preparacion = "preparacion",
                    Imagen = "url"
                });

                //RELACION
                entity
                    .HasOne<TipoMercaderia>(mercaderia => mercaderia.TipoMercaderia)
                    .WithMany(tipoMercaderia => tipoMercaderia.Mercaderias)
                    .HasForeignKey(mercaderia => mercaderia.TipoMercaderiaId);
            });

            //COMANDA
            modelBuilder.Entity<Comanda>(entity =>
            {
                entity.ToTable("Comanda");
                entity.HasKey(c => c.ComandaId);

                //RELACION
                entity
                    .HasOne<FormaEntrega>(comanda => comanda.FormaEntrega)
                    .WithMany(formaEntrega => formaEntrega.Comandas)
                    .HasForeignKey(comanda => comanda.FormaEntregaId);
            });

            //COMANDAMERCADERIA
            modelBuilder.Entity<ComandaMercaderia>(entity =>
            {
                entity.ToTable("ComandaMercaderia");
                entity.HasKey(c => c.ComandaMercaderiaId);

                //RELACION
                entity
                    .HasOne<Comanda>(comandaMercaderia => comandaMercaderia.Comanda)
                    .WithMany(comanda => comanda.ComandaMercaderias)
                    .HasForeignKey(comandaMercaderia => comandaMercaderia.ComandaId);
                entity
                    .HasOne<Mercaderia>(comandaMercaderia => comandaMercaderia.Mercaderia)
                    .WithMany(comanda => comanda.ComandaMercaderias)
                    .HasForeignKey(comandaMercaderia => comandaMercaderia.MercaderiaId);
            });

        }
    }
}
