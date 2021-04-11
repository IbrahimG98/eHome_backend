using Microsoft.EntityFrameworkCore.Migrations;

namespace eHome_backend.Migrations
{
    public partial class migration31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_State_CountryID",
                table: "State",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_State_Country_CountryID",
                table: "State",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_State_Country_CountryID",
                table: "State");

            migrationBuilder.DropIndex(
                name: "IX_State_CountryID",
                table: "State");
        }
    }
}
