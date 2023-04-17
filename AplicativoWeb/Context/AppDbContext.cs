using AplicativoWeb.EntityConfigs;
using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using  Microsoft.EntityFrameworkCore;
//instalar depedencias
public class AppDbContext: DbContext{
    // DbContext representa o banco de dados
    //Dbset representa a tabela

    //essa linha seta(Atribui)  como a entidade no banco de dados (Context)
    public DbSet<Curso> TabelaCurso => Set<Curso>(); //Representa a tabela
    // Overrride (Sobrescrever)

    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-01;Database=EscolaDotNet;user id=sa;Password=senai@123;TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new CursoEntityConfing());

    }
    

}