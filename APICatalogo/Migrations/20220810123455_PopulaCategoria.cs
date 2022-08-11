using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias( ""CategoriaId"", ""Nome"", ""Imagem"")");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
