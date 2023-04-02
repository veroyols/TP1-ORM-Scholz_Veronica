using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<TipoMercaderia> TipoMercaderiaDb { get; set; }
        public DbSet<FormaEntrega> FormaEntregaDb { get; set; }
        public DbSet<Comanda> ComandaDb { get; set; }
        public DbSet<Mercaderia> MercaderiaDb { get; set; }
        public DbSet<ComandaMercaderia> ComandaMercaderiaDb { get; set; }

        //CONECTION STRING
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=master;Trusted_Connection=True;TrustServerCertificate=True");
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
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 1,
                    Nombre = "Berenjenas en Escabeche",
                    TipoMercaderiaId = 1,
                    Precio = 100,
                    Ingredientes = "Berenjenas en Escabeche (ingredientes)",
                    Preparacion = "Berenjenas en Escabeche (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 2,
                    Nombre = "Porotos en Escabeche",
                    TipoMercaderiaId = 1,
                    Precio = 100,
                    Ingredientes = "Porotos en Escabeche (ingredientes)",
                    Preparacion = "Porotos en Escabeche (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 3,
                    Nombre = "Humus de Garbanzo",
                    TipoMercaderiaId = 1,
                    Precio = 100,
                    Ingredientes = "Humus de Garbanzo (ingredientes)",
                    Preparacion = "Humus de Garbanzo (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 4,
                    Nombre = "Milanesa Napolitana",
                    TipoMercaderiaId = 2,
                    Precio = 100,
                    Ingredientes = "Milanesa Napolitana (ingredientes)",
                    Preparacion = "Milanesa Napolitana (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 5,
                    Nombre = "Papas Fritas",
                    TipoMercaderiaId = 2,
                    Precio = 100,
                    Ingredientes = "Papas Fritas (ingredientes)",
                    Preparacion = "Papas Fritas (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 6,
                    Nombre = "Empanada",
                    TipoMercaderiaId = 2,
                    Precio = 100,
                    Ingredientes = "Empanada (ingredientes)",
                    Preparacion = "Empanada (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 7,
                    Nombre = "Omelette",
                    TipoMercaderiaId = 2,
                    Precio = 100,
                    Ingredientes = "Omelette (ingredientes)",
                    Preparacion = "Omelette (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 8,
                    Nombre = "Tarta",
                    TipoMercaderiaId = 2,
                    Precio = 100,
                    Ingredientes = "Tarta (ingredientes)",
                    Preparacion = "Tarta (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 9,
                    Nombre = "Fideos con salsa cuatro quesos",
                    TipoMercaderiaId = 3,
                    Precio = 100,
                    Ingredientes = "Fideos con salsa cuatro quesos (ingredientes)",
                    Preparacion = "Fideos con salsa cuatro quesos (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 10,
                    Nombre = "Noquis con Salsa Bolognesa",
                    TipoMercaderiaId = 3,
                    Precio = 100,
                    Ingredientes = "Noquis con Salsa Bolognesa (ingredientes)",
                    Preparacion = "Noquis con Salsa Bolognesa (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 11,
                    Nombre = "Sorrentinos con Salsa Filetto",
                    TipoMercaderiaId = 3,
                    Precio = 100,
                    Ingredientes = "Sorrentinos con Salsa Filetto (ingredientes)",
                    Preparacion = "Sorrentinos con Salsa Filetto (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 12,
                    Nombre = "Provoleta",
                    TipoMercaderiaId = 4,
                    Precio = 100,
                    Ingredientes = "Provoleta (ingredientes)",
                    Preparacion = "Provoleta (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 13,
                    Nombre = "Parrillada para 1",
                    TipoMercaderiaId = 4,
                    Precio = 100,
                    Ingredientes = "Parrillada para 1 (ingredientes)",
                    Preparacion = "Parrillada para 1 (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 14,
                    Nombre = "Parrillada para 2",
                    TipoMercaderiaId = 4,
                    Precio = 100,
                    Ingredientes = "Parrillada para 2 (ingredientes)",
                    Preparacion = "Parrillada para 2 (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 15,
                    Nombre = "Muzzarella",
                    TipoMercaderiaId = 5,
                    Precio = 100,
                    Ingredientes = "Muzzarella (ingredientes)",
                    Preparacion = "Muzzarella (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 16,
                    Nombre = "Napolitana",
                    TipoMercaderiaId = 5,
                    Precio = 100,
                    Ingredientes = "Napolitana (ingredientes)",
                    Preparacion = "Napolitana (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 17,
                    Nombre = "Roquefort",
                    TipoMercaderiaId = 5,
                    Precio = 100,
                    Ingredientes = "Roquefort (ingredientes)",
                    Preparacion = "Roquefort (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 18,
                    Nombre = "Fugazetta Rellena",
                    TipoMercaderiaId = 5,
                    Precio = 100,
                    Ingredientes = "Fugazetta Rellena (ingredientes)",
                    Preparacion = "Fugazetta Rellena (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 19,
                    Nombre = "Hamburguesa",
                    TipoMercaderiaId = 6,
                    Precio = 100,
                    Ingredientes = "Hamburguesa (ingredientes)",
                    Preparacion = "Hamburguesa (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 20,
                    Nombre = "Pollo Cesar",
                    TipoMercaderiaId = 6,
                    Precio = 100,
                    Ingredientes = "Pollo Cesar (ingredientes)",
                    Preparacion = "Pollo Cesar (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 21,
                    Nombre = "Lechuga y Cebolla",
                    TipoMercaderiaId = 7,
                    Precio = 100,
                    Ingredientes = "Lechuga y Cebolla (ingredientes)",
                    Preparacion = "Lechuga y Cebolla (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 22,
                    Nombre = "Agua",
                    TipoMercaderiaId = 8,
                    Precio = 100,
                    Ingredientes = "Agua (ingredientes)",
                    Preparacion = "Agua (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 23,
                    Nombre = "Agua con Gas",
                    TipoMercaderiaId = 8,
                    Precio = 100,
                    Ingredientes = "Agua con Gas (ingredientes)",
                    Preparacion = "Agua con Gas (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 24,
                    Nombre = "CocaCola",
                    TipoMercaderiaId = 8,
                    Precio = 100,
                    Ingredientes = "CocaCola (ingredientes)",
                    Preparacion = "CocaCola (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 25,
                    Nombre = "Agua Tonica",
                    TipoMercaderiaId = 8,
                    Precio = 100,
                    Ingredientes = "Agua Tonica (ingredientes)",
                    Preparacion = "Agua Tonica (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 26,
                    Nombre = "Vino",
                    TipoMercaderiaId = 8,
                    Precio = 100,
                    Ingredientes = "Vino (ingredientes)",
                    Preparacion = "Vino (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 27,
                    Nombre = "Blonde",
                    TipoMercaderiaId = 9,
                    Precio = 100,
                    Ingredientes = "Blonde (ingredientes)",
                    Preparacion = "Blonde (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 28,
                    Nombre = "Honey",
                    TipoMercaderiaId = 9,
                    Precio = 100,
                    Ingredientes = "Honey (ingredientes)",
                    Preparacion = "Honey (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 29,
                    Nombre = "IPA",
                    TipoMercaderiaId = 9,
                    Precio = 100,
                    Ingredientes = "IPA (ingredientes)",
                    Preparacion = "IPA (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 30,
                    Nombre = "Budin de Pan",
                    TipoMercaderiaId = 10,
                    Precio = 100,
                    Ingredientes = "Budin de Pan (ingredientes)",
                    Preparacion = "Budin de Pan (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 31,
                    Nombre = "Copa Helada",
                    TipoMercaderiaId = 10,
                    Precio = 100,
                    Ingredientes = "Copa Helada (ingredientes)",
                    Preparacion = "Copa Helada (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 32,
                    Nombre = "Panqueques con Dulce de Leche",
                    TipoMercaderiaId = 10,
                    Precio = 100,
                    Ingredientes = "Panqueques con Dulce de Leche (ingredientes)",
                    Preparacion = "Panqueques con Dulce de Leche (preparacion)",
                    Imagen = "url"
                });
                entity.HasData(new Mercaderia
                {
                    MercaderiaId = 33,
                    Nombre = "Frutilla con Crema",
                    TipoMercaderiaId = 10,
                    Precio = 100,
                    Ingredientes = "Frutilla con Crema (ingredientes)",
                    Preparacion = "Frutilla con Crema (preparacion)",
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
