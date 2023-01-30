using System;
using Microsoft.EntityFrameworkCore;

namespace GustagramApi.Model
{
    public class GustagramDb : DbContext
    {
        public GustagramDb(DbContextOptions<GustagramDb> options) : base(options)
        {
        }
        public DbSet<Mensagem> mensagens => Set<Mensagem>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mensagem>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("mensagem");


                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.From)
                    .HasColumnName("from_sender")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .HasColumnName("to_dest")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Data_msg)
                    .HasColumnName("data_msg")
                    .HasColumnType("timestap");

                entity.Property(e => e.Content)
                    .HasColumnName("msg")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

        }

    }
}
