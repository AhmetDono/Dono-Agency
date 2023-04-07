using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentPhone = table.Column<int>(type: "int", nullable: false),
                    AgentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentSocialMedia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "ContactWithAgents",
                columns: table => new
                {
                    ContactWithAgentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactWithAgents", x => x.ContactWithAgentID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertiePrice = table.Column<int>(type: "int", nullable: false),
                    PropertieIntroPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieMainPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieGridPhoto1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieGridPhoto2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieFloorPlans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieVideo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertieType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bed = table.Column<int>(type: "int", nullable: false),
                    Bath = table.Column<int>(type: "int", nullable: false),
                    Garage = table.Column<int>(type: "int", nullable: false),
                    Balcony = table.Column<bool>(type: "bit", nullable: false),
                    Deck = table.Column<bool>(type: "bit", nullable: false),
                    Parking = table.Column<bool>(type: "bit", nullable: false),
                    SportCourts = table.Column<bool>(type: "bit", nullable: false),
                    SunRoom = table.Column<bool>(type: "bit", nullable: false),
                    OutdoorKitchen = table.Column<bool>(type: "bit", nullable: false),
                    CableTV = table.Column<bool>(type: "bit", nullable: false),
                    Internet = table.Column<bool>(type: "bit", nullable: false),
                    ConcreteFlooring = table.Column<bool>(type: "bit", nullable: false),
                    PropertyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertieID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialMiniPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ContactWithAgents");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
