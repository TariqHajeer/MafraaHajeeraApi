using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MafraaHajeeraApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Father",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonalId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    MotherName = table.Column<string>(type: "text", nullable: true),
                    BirthPalce = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HealthStatus = table.Column<string>(type: "text", nullable: true),
                    RegistrationNumberAndField = table.Column<string>(type: "text", nullable: true),
                    PrevousWork = table.Column<string>(type: "text", nullable: true),
                    MonthlyIncome = table.Column<decimal>(type: "numeric", nullable: true),
                    EducationLevel = table.Column<string>(type: "text", nullable: true),
                    DeathDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Father", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mothers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    MotherName = table.Column<string>(type: "text", nullable: true),
                    BirthPalce = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RegistrationNumberAndField = table.Column<string>(type: "text", nullable: true),
                    NationalityId = table.Column<int>(type: "integer", nullable: false),
                    Phones = table.Column<string[]>(type: "text[]", nullable: true),
                    Work = table.Column<string>(type: "text", nullable: true),
                    MonthlyIncome = table.Column<decimal>(type: "numeric", nullable: true),
                    EducationLevel = table.Column<string>(type: "text", nullable: true),
                    WorkThatCanDo = table.Column<string>(type: "text", nullable: true),
                    Ambition = table.Column<string>(type: "text", nullable: true),
                    HealthStatus = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mothers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mothers_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    CurrentRegionId = table.Column<int>(type: "integer", nullable: false),
                    CurrentRegionDetails = table.Column<string>(type: "text", nullable: true),
                    OldRegionId = table.Column<int>(type: "integer", nullable: false),
                    OldRegionDetails = table.Column<string>(type: "text", nullable: true),
                    HosunigType = table.Column<int>(type: "integer", nullable: false),
                    RentCost = table.Column<decimal>(type: "numeric", nullable: true),
                    Sponser = table.Column<string>(type: "text", nullable: true),
                    OtherAssistance = table.Column<string>(type: "text", nullable: true),
                    WhoSpend = table.Column<string>(type: "text", nullable: true),
                    Dept = table.Column<string>(type: "text", nullable: true),
                    Priorities = table.Column<string[]>(type: "text[]", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    Committee = table.Column<string[]>(type: "text[]", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MotherId = table.Column<int>(type: "integer", nullable: true),
                    MotherId1 = table.Column<string>(type: "text", nullable: true),
                    FatherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Families_Father_FatherId",
                        column: x => x.FatherId,
                        principalTable: "Father",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_Mothers_MotherId1",
                        column: x => x.MotherId1,
                        principalTable: "Mothers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Families_Regions_CurrentRegionId",
                        column: x => x.CurrentRegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_Regions_OldRegionId",
                        column: x => x.OldRegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FatherName = table.Column<string>(type: "text", nullable: true),
                    MotherName = table.Column<string>(type: "text", nullable: true),
                    PersonalStatEnum = table.Column<int>(type: "integer", nullable: false),
                    Work = table.Column<string>(type: "text", nullable: true),
                    MonthlyIncom = table.Column<decimal>(type: "numeric", nullable: true),
                    HealthStatus = table.Column<string>(type: "text", nullable: true),
                    FamilyId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Child_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_FamilyId",
                table: "Child",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_CurrentRegionId",
                table: "Families",
                column: "CurrentRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_FatherId",
                table: "Families",
                column: "FatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_MotherId1",
                table: "Families",
                column: "MotherId1");

            migrationBuilder.CreateIndex(
                name: "IX_Families_OldRegionId",
                table: "Families",
                column: "OldRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Mothers_NationalityId",
                table: "Mothers",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CityId",
                table: "Regions",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "Father");

            migrationBuilder.DropTable(
                name: "Mothers");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
