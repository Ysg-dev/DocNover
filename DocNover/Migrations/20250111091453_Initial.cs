using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocNover.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    topic_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parent_topic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    document_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    document_file_extension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.id);
                    table.ForeignKey(
                        name: "FK_Documents_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TopicId",
                table: "Documents",
                column: "TopicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
