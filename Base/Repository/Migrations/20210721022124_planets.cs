using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenPath.Standard.Base.Repository.Migrations
{
    public partial class planets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnglishName",
                table: "Planets");

            migrationBuilder.AddColumn<double>(
                name: "Density",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "DeviationFromF",
                table: "Planets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "EquatorialBulge",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EquatorialDiameter",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "F",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FlatteningRatio",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Planets",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Planets",
                type: "nvarchar(64)",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "PolarDiameter",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "RotationPeriod",
                table: "Planets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Density",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "DeviationFromF",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "EquatorialBulge",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "EquatorialDiameter",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "F",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "FlatteningRatio",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "PolarDiameter",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "RotationPeriod",
                table: "Planets");

            migrationBuilder.AddColumn<string>(
                name: "EnglishName",
                table: "Planets",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                defaultValue: "");
        }
    }
}
