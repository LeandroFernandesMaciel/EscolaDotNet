using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore; //EF
using Microsoft.EntityFrameworkCore.Metadata.Builders;//Flunte API
namespace AplicativoWeb.EntityConfigs; // Novo Namespace

public class CursoEntityConfing : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso"); // Nome da tabela Curso
        /* a Expressao lambida  você usa 
        operador => para separar os parâmetros da expressão. 
        A sintaxe geral é a seguinte:
        (parametros) => expressao
        */
        builder.HasKey(C=>C.Id);//Chave primaria
        builder.Property(C=>C.TituloInterno)//Titulo Interno
               .HasColumnType("nvarchar(80)")
               .IsRequired();
        builder.Property(C=>C.TituloMarketing)
               .HasColumnType("nvarchar(80)")
               .IsRequired();
        builder.Property(C=>C.Descricao)
               .HasColumnType("nvarchar(80)")
               .IsRequired();
        



    }
}

