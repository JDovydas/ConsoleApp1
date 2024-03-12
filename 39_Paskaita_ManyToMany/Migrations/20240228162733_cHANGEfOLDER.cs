using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _39_Paskaita_ManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class cHANGEfOLDER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FileInformationFolder");

            migrationBuilder.CreateIndex(
                name: "IX_Files_FolderId",
                table: "Files",
                column: "FolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Folders_FolderId",
                table: "Files",
                column: "FolderId",
                principalTable: "Folders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Folders_FolderId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_FolderId",
                table: "Files");

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
    }
}
