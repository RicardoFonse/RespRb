using SenaiAlimentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class NivelEntityConfig : IEntityTypeConfiguration<Nivel>
{
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
       builder.ToTable("Nivel");
       builder.HasKey(n=>n.Id);
       builder.Property(n=>n.Nome)
               .HasColumnType("varchar(80)")
               .IsRequired();
    }
}