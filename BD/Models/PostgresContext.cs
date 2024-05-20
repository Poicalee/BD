using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BD1.Models;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Czytelnik> Czytelniks { get; set; }

    public virtual DbSet<Ksiązki> Ksiązkis { get; set; }

    public virtual DbSet<Pracownik> Pracowniks { get; set; }

    public virtual DbSet<Wypożyczenie> Wypożyczenies { get; set; }

    public virtual DbSet<Wypożyczenium> Wypożyczenia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=Kubek234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("pg_catalog", "adminpack")
            .HasPostgresExtension("pgagent", "pgagent");

        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("autor_pkey");

            entity.ToTable("autor");

            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.AuthorName)
                .HasMaxLength(255)
                .HasColumnName("author_name");
        });

        modelBuilder.Entity<Czytelnik>(entity =>
        {
            entity.HasKey(e => e.ReaderId).HasName("czytelnik_pkey");

            entity.ToTable("czytelnik");

            entity.Property(e => e.ReaderId).HasColumnName("reader_id");
            entity.Property(e => e.ReaderAddress)
                .HasMaxLength(255)
                .HasColumnName("reader_address");
            entity.Property(e => e.ReaderName)
                .HasMaxLength(255)
                .HasColumnName("reader_name");
            entity.Property(e => e.ReaderPhone)
                .HasMaxLength(20)
                .HasColumnName("reader_phone");
        });

        modelBuilder.Entity<Ksiązki>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("ksiązki_pkey");

            entity.ToTable("ksiązki");

            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.Available).HasColumnName("available");
            entity.Property(e => e.Genre)
                .HasMaxLength(100)
                .HasColumnName("genre");
            entity.Property(e => e.PublicationYear).HasColumnName("publication_year");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnName("title");

            entity.HasOne(d => d.Author).WithMany(p => p.Ksiązkis)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("ksiązki_author_id_fkey");
        });

        modelBuilder.Entity<Pracownik>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("pracownik_pkey");

            entity.ToTable("pracownik");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.EmployeeAddress)
                .HasMaxLength(255)
                .HasColumnName("employee_address");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(255)
                .HasColumnName("employee_name");
            entity.Property(e => e.EmployeePhone)
                .HasMaxLength(20)
                .HasColumnName("employee_phone");
            entity.Property(e => e.EmployeePosition)
                .HasMaxLength(100)
                .HasColumnName("employee_position");
            entity.Property(e => e.EmployeeSalary)
                .HasPrecision(10, 2)
                .HasColumnName("employee_salary");
        });

        modelBuilder.Entity<Wypożyczenie>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("wypożyczenie_pkey");

            entity.ToTable("wypożyczenie");

            entity.Property(e => e.LoanId).HasColumnName("loan_id");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.LoanDate).HasColumnName("loan_date");
            entity.Property(e => e.ReaderId).HasColumnName("reader_id");
            entity.Property(e => e.ReturnDate).HasColumnName("return_date");
            entity.Property(e => e.Returned).HasColumnName("returned");

            entity.HasOne(d => d.Book).WithMany(p => p.Wypożyczenies)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("wypożyczenie_book_id_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.Wypożyczenies)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("wypożyczenie_employee_id_fkey");

            entity.HasOne(d => d.Reader).WithMany(p => p.Wypożyczenies)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("wypożyczenie_reader_id_fkey");
        });

        modelBuilder.Entity<Wypożyczenium>(entity =>
        {
            entity.HasKey(e => e.WypId).HasName("wypożyczenia_pkey");

            entity.ToTable("wypożyczenia");

            entity.Property(e => e.WypId).HasColumnName("wyp_id");
            entity.Property(e => e.BookId).HasColumnName("book_id");
            entity.Property(e => e.LoanDate).HasColumnName("loan_date");
            entity.Property(e => e.ReaderId).HasColumnName("reader_id");
            entity.Property(e => e.ReturnDate).HasColumnName("return_date");
            entity.Property(e => e.Returned).HasColumnName("returned");

            entity.HasOne(d => d.Book).WithMany(p => p.Wypożyczenia)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("wypożyczenia_book_id_fkey");

            entity.HasOne(d => d.Reader).WithMany(p => p.Wypożyczenia)
                .HasForeignKey(d => d.ReaderId)
                .HasConstraintName("wypożyczenia_reader_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
