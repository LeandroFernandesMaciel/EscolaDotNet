using AplicativoWeb.Models; // Cahamando a Camada Modelo...
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.EntityConfigs;

// Trabalho para amanhâ : Instalar Depedenciais
public class AppDbContext:DbContext{ //DbContext representa o banco de dados

                    //DbSet representa a tabela 
                    //Essa linha Seta (atribui) a classe Curso como a ententidade no banco de dados (Context) EscolaDotNet
    public DbSet<Curso> Cursos => Set<Curso>(); //Representa a tabela

    //overrride (sobrescrever)
    //NãoTrai ( ) - Contrato
    //CompatilhaCarteira()
    //protected
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-04;Database=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=true");
    }
    protected override void OnModelCreating(ModelBuilder builder){
        
    }
}