using Api_Endereco.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace Api_Endereco.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api_Endereco.Models.Endereco", b => // Verifique se o namespace e o nome da classe estão corretos
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("NUMBER(10)");

                OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Rua")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("Cidade")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(2000)");

                b.Property<string>("Estado")
                    .IsRequired()
                    .HasColumnType("NVARCHAR2(2000)");

                b.HasKey("Id");

                b.ToTable("Enderecos");
            });
#pragma warning restore 612, 618
        }
    }
}
