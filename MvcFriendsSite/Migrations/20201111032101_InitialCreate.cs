using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFriendsSite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alias",
                table: "UserModel",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "socialWebsite",
                table: "UserModel",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "website",
                table: "UserModel",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alias",
                table: "UserModel");

            migrationBuilder.DropColumn(
                name: "socialWebsite",
                table: "UserModel");

            migrationBuilder.DropColumn(
                name: "website",
                table: "UserModel");
        }
    }
}
