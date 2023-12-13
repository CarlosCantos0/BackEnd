using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Modelos.Auth;
using PruebasBackendModelo.Modelo;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebasBackendDomain.Context
{
    public partial class PruebasBackendContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public PruebasBackendContext()
        {
        }

        public PruebasBackendContext(DbContextOptions<PruebasBackendContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        //public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        //public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        //public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        //public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        //public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Inspector> Inspector { get; set; }
        public virtual DbSet<Inspector20201130> Inspector20201130 { get; set; }
        public virtual DbSet<InspectorCopia> InspectorCopia { get; set; }
        public virtual DbSet<InspectorDisponible> InspectorDisponible { get; set; }
        public virtual DbSet<MatrixGoogle> MatrixGoogle { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<TipoInspeccion> TipoInspeccion { get; set; }
        public virtual DbSet<Tramos> Tramos { get; set; }
        public virtual DbSet<TramosId> TramosId { get; set; }
        public virtual DbSet<VEsquema> VInspecciones { get; set; }

        public virtual DbSet<Esquema> Esquema { get; set; }
        public virtual DbSet<Elemento> Elemento { get; set; }
        public virtual DbSet<TipoElemento> TipoElemento { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=192.168.30.243,55555;Database=BVData;User Id=Juanjo;Password=J12345678-j;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetRoleClaims>(entity =>
            //{
            //    entity.ToTable("AspNetRoleClaims", "users");

            //    entity.HasIndex(e => e.RoleId);

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspNetRoleClaims)
            //        .HasForeignKey(d => d.RoleId);
            //});

            //modelBuilder.Entity<AspNetRoles>(entity =>
            //{
            //    entity.ToTable("AspNetRoles", "users");

            //    entity.HasIndex(e => e.NormalizedName)
            //        .HasName("RoleNameIndex")
            //        .IsUnique()
            //        .HasFilter("([NormalizedName] IS NOT NULL)");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Name).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedName).HasMaxLength(256);
            //});

            //modelBuilder.Entity<AspNetUserClaims>(entity =>
            //{
            //    entity.ToTable("AspNetUserClaims", "users");

            //    entity.HasIndex(e => e.UserId);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserClaims)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserLogins>(entity =>
            //{
            //    entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            //    entity.ToTable("AspNetUserLogins", "users");

            //    entity.HasIndex(e => e.UserId);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserLogins)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserRoles>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.RoleId });

            //    entity.ToTable("AspNetUserRoles", "users");

            //    entity.HasIndex(e => e.RoleId);

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.AspNetUserRoles)
            //        .HasForeignKey(d => d.RoleId);

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserRoles)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUserTokens>(entity =>
            //{
            //    entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            //    entity.ToTable("AspNetUserTokens", "users");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.AspNetUserTokens)
            //        .HasForeignKey(d => d.UserId);
            //});

            //modelBuilder.Entity<AspNetUsers>(entity =>
            //{
            //    entity.ToTable("AspNetUsers", "users");

            //    entity.HasIndex(e => e.NormalizedEmail)
            //        .HasName("EmailIndex");

            //    entity.HasIndex(e => e.NormalizedUserName)
            //        .HasName("UserNameIndex")
            //        .IsUnique()
            //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Alias).HasMaxLength(50);

            //    entity.Property(e => e.Email).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

            //    entity.Property(e => e.UserName).HasMaxLength(256);
            //});

            modelBuilder.Entity<Elemento>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoordX).HasColumnName("coordX");

                entity.Property(e => e.CoordY).HasColumnName("coordY");

                entity.Property(e => e.Fill)
                    .HasColumnName("fill")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Fonts)
                    .HasColumnName("fonts")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.IdEsquema).HasColumnName("idEsquema");

                entity.Property(e => e.IdTipoElemento).HasColumnName("idTipoElemento");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rellenado).HasColumnName("rellenado");

                entity.Property(e => e.SizeLetter).HasColumnName("sizeLetter");

                entity.Property(e => e.Stroke)
                    .HasColumnName("stroke")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.StrokeWidth).HasColumnName("strokeWidth");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnName("width");

                entity.Property(e => e.X1).HasColumnName("x1");

                entity.Property(e => e.X2).HasColumnName("x2");

                entity.Property(e => e.Y1).HasColumnName("y1");

                entity.Property(e => e.Y2).HasColumnName("y2");

                entity.Property(e => e.ScaleX).HasColumnName("scaleX");

                entity.Property(e => e.ScaleY).HasColumnName("scaleY");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.EstadoBorde).HasColumnName("estadoBorde");



                entity.HasOne(d => d.IdEsquemaNavigation)
                    .WithMany(p => p.Elemento)
                    .HasForeignKey(d => d.IdEsquema)
                    .HasConstraintName("FK_Elemento_Esquema");

                entity.HasOne(d => d.IdTipoElementoNavigation)
                    .WithMany(p => p.Elemento)
                    .HasForeignKey(d => d.IdTipoElemento)
                    .HasConstraintName("FK_Elemento_TipoElemento");
            });

            modelBuilder.Entity<TipoElemento>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Esquema>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fechaAlta")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");


                //entity.HasOne<AspNetUsers>()
                //   .WithMany()
                //   .HasForeignKey(d => d.IdUsuario)
                //   .HasConstraintName("FK_Esquema_AspNetUsers");

            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasIndex(e => new { e.Idmunicipio, e.Direccion, e.FechaInspeccion })
                    .HasName("IX_Cliente")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInspeccion).HasColumnType("date");

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.IdtipoInspeccion).HasColumnName("IDTipoInspeccion");

                entity.Property(e => e.Lat).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Lng).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdmunicipioNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.Idmunicipio)
                    .HasConstraintName("FK_Cliente_Municipio");

                entity.HasOne(d => d.IdtipoInspeccionNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdtipoInspeccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_TipoInspeccion");
            });

            modelBuilder.Entity<Inspector>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_TipoInspector")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.IdtipoInspeccion).HasColumnName("IDTipoInspeccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdmunicipioNavigation)
                    .WithMany(p => p.Inspector)
                    .HasForeignKey(d => d.Idmunicipio)
                    .HasConstraintName("FK_TipoInspector_Municipio");

                entity.HasOne(d => d.IdtipoInspeccionNavigation)
                    .WithMany(p => p.Inspector)
                    .HasForeignKey(d => d.IdtipoInspeccion)
                    .HasConstraintName("FK_TipoInspector_TipoInspeccion");
            });

            modelBuilder.Entity<Inspector20201130>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inspector_20201130");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.IdtipoInspeccion).HasColumnName("IDTipoInspeccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InspectorCopia>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.IdtipoInspeccion).HasColumnName("IDTipoInspeccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InspectorDisponible>(entity =>
            {
                entity.HasIndex(e => e.Disponible);

                entity.HasIndex(e => new { e.Id, e.Fecha })
                    .HasName("IX_InspectorDisponible")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Idinspector).HasColumnName("IDInspector");

                entity.HasOne(d => d.IdinspectorNavigation)
                    .WithMany(p => p.InspectorDisponible)
                    .HasForeignKey(d => d.Idinspector)
                    .HasConstraintName("FK_InspectorDisponible_Inspector");
            });

            modelBuilder.Entity<MatrixGoogle>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Iddestino).HasColumnName("IDDestino");

                entity.Property(e => e.Idorigen).HasColumnName("IDOrigen");

                entity.Property(e => e.LatDestino).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.LatOrigen).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.LngDestino).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.LngOrigen).HasColumnType("numeric(9, 6)");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasIndex(e => e.NombreCompleto)
                    .HasName("IX_Municipio")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoInspeccion>(entity =>
            {
                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_TipoInspeccion")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tramos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DesdeLatitud).HasColumnType("numeric(15, 6)");

                entity.Property(e => e.DesdeLongitud).HasColumnType("numeric(15, 6)");

                entity.Property(e => e.DireccionLlegada)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionSalida)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fin).HasColumnType("datetime");

                entity.Property(e => e.HastaLatitud).HasColumnType("numeric(15, 6)");

                entity.Property(e => e.HastaLongitud).HasColumnType("numeric(15, 6)");

                entity.Property(e => e.Idref).HasColumnName("IDRef");

                entity.Property(e => e.Idtramo).HasColumnName("IDTramo");

                entity.Property(e => e.IdtramoOpt).HasColumnName("IDTramoOpt");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Km)
                    .HasColumnName("KM")
                    .HasComputedColumnSql("(CONVERT([real],[Metros])/(1000))");

                entity.Property(e => e.Tiempo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(CONVERT([varchar],dateadd(millisecond,[Segundos]*(1000),(0)),(114)))");

                entity.HasOne(d => d.IdrefNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idref)
                    .HasConstraintName("FK_Tramos_TramosID");
            });

            modelBuilder.Entity<TramosId>(entity =>
            {
                entity.ToTable("TramosID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<VInspecciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInspecciones");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTipoInspeccion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInspeccion).HasColumnType("date");

                entity.Property(e => e.Idcliente).HasColumnName("IDCliente");

                entity.Property(e => e.Idmunicipio).HasColumnName("IDMunicipio");

                entity.Property(e => e.IdtipoInspeccion).HasColumnName("IDTipoInspeccion");

                entity.Property(e => e.Lat).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Lng).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInspeccion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<AppUser>().ToTable("AspNetUsers", "users");
            modelBuilder.Entity<AppRole>().ToTable("AspNetRoles", "users");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AspNetRoleClaims", "users");
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AspNetUserClaims", "users");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AspNetUserLogins", "users");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AspNetUserRoles", "users");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AspNetUserTokens", "users");

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
