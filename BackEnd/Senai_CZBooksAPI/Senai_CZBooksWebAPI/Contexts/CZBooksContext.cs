using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai_CZBooksWebAPI.Domains;

#nullable disable

namespace Senai_CZBooksWebAPI.Contexts
{
    public partial class CZBooksContext : DbContext
    {
        public CZBooksContext()
        {
        }

        public CZBooksContext(DbContextOptions<CZBooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-FQM2QUJ\\SQLEXPRESS; Initial Catalog= CZ_Books; user Id=sa; pwd=senai@132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__Autor__DD33B031963E9E9C");

                entity.ToTable("Autor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Autor__IdUsuario__4222D4EF");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A10F10DB7A9");

                entity.Property(e => e.NomeCategoria)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresas)
                    .HasName("PK__EMPRESAS__C8A3621CD0EE1CA6");

                entity.ToTable("EMPRESAS");

                entity.HasIndex(e => e.NomeEmpresa, "UQ__EMPRESAS__3C3E55F08FE25D43")
                    .IsUnique();

                entity.Property(e => e.Endereço)
                    .IsRequired()
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.NomeEmpresa)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.IdLivros)
                    .HasName("PK__Livros__F1B181B3F3FF6990");

                entity.HasIndex(e => e.Titulo, "UQ__Livros__7B406B567B567F8C")
                    .IsUnique();

                entity.Property(e => e.Autor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataPublicação)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dataPublicação");

                entity.Property(e => e.IdAutor).HasColumnName("idAutor");

                entity.Property(e => e.Sinopse)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__Livros__idAutor__4F7CD00D");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Livros__IdCatego__5070F446");
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__TiposUsu__CA04062B66C7BE5D");

                entity.ToTable("TiposUsuario");

                entity.HasIndex(e => e.TituloTipoUsuario, "UQ__TiposUsu__37BBE07E17CFAFFE")
                    .IsUnique();

                entity.Property(e => e.TituloTipoUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__5B65BF9795CA3771");

                entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D10534E90073E6")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SENHA");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__Usuarios__IdTipo__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
