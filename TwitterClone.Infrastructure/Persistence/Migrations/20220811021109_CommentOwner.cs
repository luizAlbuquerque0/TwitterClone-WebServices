using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TwitterClone.Infrastructure.Persistence.Migrations
{
    public partial class CommentOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CommentOwnerName",
                table: "PostComments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentOwnerName",
                table: "PostComments");
        }
    }
}
