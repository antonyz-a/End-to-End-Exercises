using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEDC.PizzaApp.DataAccess.Migrations
{
    public partial class init_test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name", "UserId" },
                values: new object[] { 1, "test@gmail.com", "Siciliana was too salty this time", "Too salty", 1 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name", "UserId" },
                values: new object[] { 2, "test@gmail.com", "10 stars to the chef for the Mexicana", "Exelent", 2 });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Email", "Message", "Name", "UserId" },
                values: new object[] { 3, "test@gmail.com", "Check your cheff", "I found a finger in your pizza", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
