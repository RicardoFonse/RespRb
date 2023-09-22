using Microsoft.EntityFrameworkCore;
using SenaiAlimentos.Models;//usando um framework
namespace SenaiAlimentos.Contexts;

public class AppDbContext : DbContext
{  
     public DbSet<Nivel> Niveis=> Set<Nivel>();//representa a tabela
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
       builder.UseSqlServer("Server=LAB-F08-19;Database=SenaiAlimentos;User Id=sa;Password=senai@123;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new  NivelEntityConfig());
    }
}