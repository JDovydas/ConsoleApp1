using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _39_Paskaita_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class Check : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FileInformationFolder",
                columns: table => new
                {
                    FileFoldersId = table.Column<int>(type: "int", nullable: false),
                    FolderFileInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileInformationFolder", x => new { x.FileFoldersId, x.FolderFileInformationId });
                    table.ForeignKey(
                        name: "FK_FileInformationFolder_Files_FolderFileInformationId",
                        column: x => x.FolderFileInformationId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileInformationFolder_Folders_FileFoldersId",
                        column: x => x.FileFoldersId,
                        principalTable: "Folders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileInformationFolder_FolderFileInformationId",
                table: "FileInformationFolder",
                column: "FolderFileInformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileInformationFolder");
        }
    }
}
