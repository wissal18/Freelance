using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Freelance_Platform.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Freelancers",
                columns: table => new
                {
                    FreelancerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerHour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancers", x => x.FreelancerID);
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    TalentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.TalentID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    ExperienceLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Freelancers_Talents",
                columns: table => new
                {
                    TalentID = table.Column<int>(type: "int", nullable: false),
                    FreelancerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancers_Talents", x => new { x.FreelancerID, x.TalentID });
                    table.ForeignKey(
                        name: "FK_Freelancers_Talents_Freelancers_FreelancerID",
                        column: x => x.FreelancerID,
                        principalTable: "Freelancers",
                        principalColumn: "FreelancerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Freelancers_Talents_Talents_TalentID",
                        column: x => x.TalentID,
                        principalTable: "Talents",
                        principalColumn: "TalentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects_Talents",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    TalentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects_Talents", x => new { x.ProjectID, x.TalentID });
                    table.ForeignKey(
                        name: "FK_Projects_Talents_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Talents_Talents_TalentID",
                        column: x => x.TalentID,
                        principalTable: "Talents",
                        principalColumn: "TalentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_Talents_TalentID",
                table: "Freelancers_Talents",
                column: "TalentID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientID",
                table: "Projects",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Talents_TalentID",
                table: "Projects_Talents",
                column: "TalentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Freelancers_Talents");

            migrationBuilder.DropTable(
                name: "Projects_Talents");

            migrationBuilder.DropTable(
                name: "Freelancers");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Talents");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
