using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PratikSurvivor.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competitors_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7733), false, null, "Ünlüler" },
                    { 2, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7745), false, null, "Gönüllüler" }
                });

            migrationBuilder.InsertData(
                table: "Competitors",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "FirstName", "IsDeleted", "LastName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7835), "Acun", false, "Ilıcalı", null },
                    { 2, 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7837), "Aleyna", false, "Avcı", null },
                    { 3, 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7838), "Hadise", false, "Açıkgöz", null },
                    { 4, 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7839), "Sertan", false, "Bozkuş", null },
                    { 5, 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7839), "Özge", false, "Açık", null },
                    { 6, 1, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7840), "Kıvanç", false, "Tatlıtuğ", null },
                    { 7, 2, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7841), "Ahmet", false, "Yılmaz", null },
                    { 8, 2, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7842), "Elif", false, "Demirtaş", null },
                    { 9, 2, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7842), "Cem", false, "Öztürk", null },
                    { 10, 2, new DateTime(2025, 3, 22, 17, 37, 21, 349, DateTimeKind.Local).AddTicks(7843), "Ayşe", false, "Karaca", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competitors_CategoryId",
                table: "Competitors",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competitors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
