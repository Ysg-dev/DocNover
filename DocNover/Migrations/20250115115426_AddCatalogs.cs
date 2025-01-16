using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocNover.Migrations
{
    /// <inheritdoc />
    public partial class AddCatalogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catalog_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    catalog_discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    catalog_image_paths = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    document_id = table.Column<int>(type: "int", nullable: false),
                    topic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogs");
        }
    }
}
