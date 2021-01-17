using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppInicial.DAL.Models
{
    public partial class bd_tallerContext : DbContext
    {
        public bd_tallerContext()
        {
        }

        public bd_tallerContext(DbContextOptions<bd_tallerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Concesionario> Concesionario { get; set; }
        public virtual DbSet<Propuesta> Propuesta { get; set; }
        public virtual DbSet<Repara> Repara { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=123456;database=bd_taller");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("DNI")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Concesionario>(entity =>
            {
                entity.HasKey(e => e.IdConcesionario)
                    .HasName("PRIMARY");

                entity.ToTable("concesionario");

                entity.Property(e => e.IdConcesionario).HasColumnName("idConcesionario");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Nombre).HasMaxLength(45);
            });

            modelBuilder.Entity<Propuesta>(entity =>
            {
                entity.HasKey(e => e.IdPropuesta)
                    .HasName("PRIMARY");

                entity.ToTable("propuesta");

                entity.HasIndex(e => e.Cliente)
                    .HasName("idCliente_idx");

                entity.HasIndex(e => e.Usuario)
                    .HasName("idUsuario_idx");

                entity.HasIndex(e => e.VehMatricula)
                    .HasName("Matricula_idx");

                entity.Property(e => e.IdPropuesta).HasColumnName("idPropuesta");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.VehMatricula)
                    .IsRequired()
                    .HasColumnName("Veh_Matricula")
                    .HasMaxLength(8);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Propuesta)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cliente");

                entity.HasOne(d => d.UsuarioNavigation)
                    .WithMany(p => p.Propuesta)
                    .HasForeignKey(d => d.Usuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Usuario");

                entity.HasOne(d => d.VehMatriculaNavigation)
                    .WithMany(p => p.Propuesta)
                    .HasForeignKey(d => d.VehMatricula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Veh_Matricula");
            });

            modelBuilder.Entity<Repara>(entity =>
            {
                entity.HasKey(e => e.IdRepara)
                    .HasName("PRIMARY");

                entity.ToTable("repara");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("idUsuario_idx");

                entity.HasIndex(e => e.Matricula)
                    .HasName("idCliente_idx");

                entity.Property(e => e.IdRepara).HasColumnName("idRepara");

                entity.Property(e => e.Estado).HasMaxLength(45);

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("Fecha_Entrada")
                    .HasColumnType("date");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("Fecha_Salida")
                    .HasColumnType("date");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Piezas).HasMaxLength(500);

                entity.Property(e => e.Tarea).HasMaxLength(500);

                entity.Property(e => e.Tiempo).HasMaxLength(45);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Repara)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("idUsuario");

                entity.HasOne(d => d.MatriculaNavigation)
                    .WithMany(p => p.Repara)
                    .HasForeignKey(d => d.Matricula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Matricula");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.Concesionario)
                    .HasName("Concesionario_idx");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EspCiclomotores).HasColumnName("Esp_Ciclomotores");

                entity.Property(e => e.EspCoches).HasColumnName("Esp_Coches");

                entity.Property(e => e.EspMotos).HasColumnName("Esp_Motos");

                entity.Property(e => e.MecanicoJefe).HasColumnName("Mecanico_Jefe");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rol).HasMaxLength(45);

                entity.Property(e => e.Telefono).HasMaxLength(10);

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasColumnName("Usuario")
                    .HasMaxLength(20);

                entity.HasOne(d => d.ConcesionarioNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.Concesionario)
                    .HasConstraintName("Concesionario");
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(e => e.Matricula)
                    .HasName("PRIMARY");

                entity.ToTable("vehiculo");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("idCliente_idx");

                entity.HasIndex(e => e.IdConcesionario)
                    .HasName("idConcesionario_idx");

                entity.Property(e => e.Matricula).HasMaxLength(8);

                entity.Property(e => e.Color)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Combustible).HasMaxLength(15);

                entity.Property(e => e.FechaEntrada).HasColumnType("date");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdConcesionario).HasColumnName("idConcesionario");

                entity.Property(e => e.Kilometros).HasDefaultValueSql("'0'");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Tipo).HasMaxLength(15);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Vehiculo)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("idCliente");

                entity.HasOne(d => d.IdConcesionarioNavigation)
                    .WithMany(p => p.Vehiculo)
                    .HasForeignKey(d => d.IdConcesionario)
                    .HasConstraintName("idConcesionario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
