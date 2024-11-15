using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMediaApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSocialMediaAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_SocialMediaAccounts_SocialMediaAccountId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SocialMediaAccountId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "SocialMediaAccounts");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "SocialMediaAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(280)",
                oldMaxLength: 280);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "SocialMediaAccounts");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "SocialMediaAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "nvarchar(280)",
                maxLength: 280,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SocialMediaAccountId",
                table: "Posts",
                column: "SocialMediaAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_SocialMediaAccounts_SocialMediaAccountId",
                table: "Posts",
                column: "SocialMediaAccountId",
                principalTable: "SocialMediaAccounts",
                principalColumn: "SocialMediaAccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
