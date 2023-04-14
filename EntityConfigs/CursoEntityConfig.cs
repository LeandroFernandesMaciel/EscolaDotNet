using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;//FLUENT API

namespace AplicativoWeb.EntityConfigs;

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");

        //Id
        // Unica - Universal - Imuntável 
        builder.HasKey(c=>c.Id); // Chave primaria

        //Titulo marketing
        builder.Property(c=>c.TituloMarketing)
             .HasColumnType("nvarchar(80)")
             .IsRequired();

             
        //Titulo Interno
        builder.Property(c=>c.TituloInterno) 
             .HasColumnType("nvarchar(80)")
             .IsRequired();

        //Desrição
        builder.Property(c=>c.Descricao)
             .HasColumnType("text")
             .IsRequired();
    }
}