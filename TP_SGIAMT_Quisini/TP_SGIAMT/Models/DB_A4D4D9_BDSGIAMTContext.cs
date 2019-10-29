using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TP_SGIAMT.Models
{
    public partial class DB_A4D4D9_BDSGIAMTContext : DbContext
    {
        public DB_A4D4D9_BDSGIAMTContext()
        {
        }

        public DB_A4D4D9_BDSGIAMTContext(DbContextOptions<DB_A4D4D9_BDSGIAMTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TArchivoUsuario> TArchivoUsuario { get; set; }
        public virtual DbSet<TCategoria> TCategoria { get; set; }
        public virtual DbSet<TConcurso> TConcurso { get; set; }
        public virtual DbSet<TEstadoCon> TEstadoCon { get; set; }
        public virtual DbSet<TModalidadCon> TModalidadCon { get; set; }
        public virtual DbSet<TTipoUsuario> TTipoUsuario { get; set; }
        public virtual DbSet<TUsuario> TUsuario { get; set; }
        public virtual DbSet<TUsuarioModalidad> TUsuarioModalidad { get; set; }

        // Unable to generate entity type for table 'dbo.Usuario'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ssql5047.site4now.net;Database=DB_A4F05E_SGIAMTP;User Id=DB_A4F05E_SGIAMTP_admin;Password=123456789gg");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TArchivoUsuario>(entity =>
            {
                entity.HasKey(e => e.PkIauIdArchivo);

                entity.ToTable("T_ArchivoUsuario");

                entity.Property(e => e.PkIauIdArchivo)
                    .HasColumnName("PK_IAU_IdArchivo")
                    .ValueGeneratedNever();

                entity.Property(e => e.VauArchivo)
                    .HasColumnName("VAU_Archivo")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TCategoria>(entity =>
            {
                entity.HasKey(e => e.PkIcCodCat);

                entity.ToTable("T_Categoria");

                entity.Property(e => e.PkIcCodCat)
                    .HasColumnName("PK_IC_CodCat")
                    .ValueGeneratedNever();

                entity.Property(e => e.VcNomCategoria)
                    .HasColumnName("VC_NomCategoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TConcurso>(entity =>
            {
                entity.HasKey(e => e.PkIcIdConcurso);

                entity.ToTable("T_Concurso");

                entity.Property(e => e.PkIcIdConcurso).HasColumnName("PK_IC_IdConcurso");

                entity.Property(e => e.DcFechaConcurso)
                    .HasColumnName("DC_FechaConcurso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkIecIdEstado).HasColumnName("FK_IEC_IdEstado");

                entity.Property(e => e.IcCantidadNove).HasColumnName("IC_CantidadNove");

                entity.Property(e => e.IcCantidadSeri).HasColumnName("IC_CantidadSeri");

                entity.Property(e => e.VcLugarCon)
                    .HasColumnName("VC_LugarCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcNombreCon)
                    .HasColumnName("VC_NombreCon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIecIdEstadoNavigation)
                    .WithMany(p => p.TConcurso)
                    .HasForeignKey(d => d.FkIecIdEstado)
                    .HasConstraintName("FK_T_Concurso_T_EstadoCon");
            });

            modelBuilder.Entity<TEstadoCon>(entity =>
            {
                entity.HasKey(e => e.PkIeIdEstado);

                entity.ToTable("T_EstadoCon");

                entity.Property(e => e.PkIeIdEstado)
                    .HasColumnName("PK_IE_IdEstado")
                    .ValueGeneratedNever();

                entity.Property(e => e.VeNombreEsta)
                    .HasColumnName("VE_NombreEsta")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TModalidadCon>(entity =>
            {
                entity.HasKey(e => e.PkImIdModalidad);

                entity.ToTable("T_ModalidadCon");

                entity.Property(e => e.PkImIdModalidad)
                    .HasColumnName("PK_IM_IdModalidad")
                    .ValueGeneratedNever();

                entity.Property(e => e.VmNombreMod)
                    .HasColumnName("VM_NombreMod")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.PkItuTipoUsuario);

                entity.ToTable("T_TipoUsuario");

                entity.Property(e => e.PkItuTipoUsuario)
                    .HasColumnName("PK_ITU_TipoUsuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.VtuNombreTipoUsuario)
                    .HasColumnName("VTU_NombreTipoUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUsuario>(entity =>
            {
                entity.HasKey(e => e.PkIuDni);

                entity.ToTable("T_Usuario");

                entity.Property(e => e.PkIuDni)
                    .HasColumnName("PK_IU_Dni")
                    .ValueGeneratedNever();

                entity.Property(e => e.DuFechaNacimiento)
                    .HasColumnName("DU_FechaNacimiento")
                    .HasColumnType("datetime");

<<<<<<< HEAD
                entity.Property(e => e.FkIauIdArchivo)
                .HasColumnName("FK_IAU_IdArchivo");

                entity.Property(e => e.FkItuTipoUsuario)
                .HasColumnName("FK_ITU_TipoUsuario");

                entity.Property(e => e.FkIuCodCategoria)
                .HasColumnName("FK_IU_CodCategoria");
=======
                entity.Property(e => e.FkIauIdArchivo).HasColumnName("FK_IAU_IdArchivo");

                entity.Property(e => e.FkItuTipoUsuario).HasColumnName("FK_ITU_TipoUsuario");

                entity.Property(e => e.FkIuCodCategoria).HasColumnName("FK_IU_CodCategoria");
>>>>>>> 69f5eddd531708e2401d39e31741a17cdab79439

                entity.Property(e => e.VuAmaterno)
                    .HasColumnName("VU_AMaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuApaterno)
                    .HasColumnName("VU_APaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuContraseña)
                    .HasColumnName("VU_Contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuNacademia)
                    .HasColumnName("VU_NAcademia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuNombre)
                    .HasColumnName("VU_Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuSexo)
                    .HasColumnName("VU_Sexo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkIauIdArchivoNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkIauIdArchivo)
                    .HasConstraintName("FK_T_Usuario_T_ArchivoUsuario");

                entity.HasOne(d => d.FkItuTipoUsuarioNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkItuTipoUsuario)
                    .HasConstraintName("FK_T_Usuario_T_TipoUsuario");

                entity.HasOne(d => d.FkIuCodCategoriaNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkIuCodCategoria)
                    .HasConstraintName("FK_T_Usuario_T_Categoria");
            });

            modelBuilder.Entity<TUsuarioModalidad>(entity =>
            {
                entity.HasKey(e => e.PkIumCodUm);

                entity.ToTable("T_Usuario_Modalidad");

                entity.Property(e => e.PkIumCodUm)
                    .HasColumnName("PK_IUM_CodUM")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkIcIdConcurso).HasColumnName("FK_IC_IdConcurso");

                entity.Property(e => e.FkImIdModalidad).HasColumnName("FK_IM_IdModalidad");

                entity.Property(e => e.FkIuDni).HasColumnName("FK_IU_Dni");

                entity.HasOne(d => d.FkIcIdConcursoNavigation)
                    .WithMany(p => p.TUsuarioModalidad)
                    .HasForeignKey(d => d.FkIcIdConcurso)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_Concurso");

                entity.HasOne(d => d.FkImIdModalidadNavigation)
                    .WithMany(p => p.TUsuarioModalidad)
                    .HasForeignKey(d => d.FkImIdModalidad)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_ModalidadCon");

                entity.HasOne(d => d.FkIuDniNavigation)
                    .WithMany(p => p.TUsuarioModalidad)
                    .HasForeignKey(d => d.FkIuDni)
                    .HasConstraintName("FK_T_Usuario_Modalidad_T_Usuario");
            });
        }
    }
}
