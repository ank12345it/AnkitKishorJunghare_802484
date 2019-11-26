using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnologyService.Migrations
{
    public partial class m23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Mentor_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mentor_Name = table.Column<string>(nullable: false),
                    Mentor_Mobile = table.Column<long>(nullable: false),
                    Mentor_Email = table.Column<string>(nullable: false),
                    Mentor_Password = table.Column<string>(nullable: false),
                    Mentor_Exp = table.Column<string>(nullable: false),
                    Mentor_PrimarySkill = table.Column<string>(nullable: false),
                    Mentor_From_TimeSlot = table.Column<string>(nullable: true),
                    Mentor_To_TimeSlot = table.Column<string>(nullable: true),
                    Mentor_Availability = table.Column<bool>(nullable: true),
                    Mentor_active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Mentor_Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Skill_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skill_Name = table.Column<string>(nullable: true),
                    Skill_Toc = table.Column<string>(nullable: true),
                    Skill_Fee = table.Column<double>(nullable: false),
                    Skill_Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Skill_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(nullable: false),
                    User_Email = table.Column<string>(nullable: false),
                    User_Mobile = table.Column<long>(nullable: false),
                    User_Password = table.Column<string>(nullable: true),
                    User_active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_Id);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Training_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<long>(nullable: false),
                    Mentor_Id = table.Column<long>(nullable: false),
                    Skill_Id = table.Column<long>(nullable: false),
                    StartTime = table.Column<DateTime>(type: "Date", nullable: false),
                    EndTime = table.Column<DateTime>(type: "Date", nullable: false),
                    Mentor_From_TimeSlot = table.Column<string>(nullable: true),
                    Mentor_To_TimeSlot = table.Column<string>(nullable: true),
                    Training_Status = table.Column<string>(nullable: true),
                    Training_Progress = table.Column<long>(nullable: false),
                    rating = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Training_Id);
                    table.ForeignKey(
                        name: "FK_Training_Mentor_Mentor_Id",
                        column: x => x.Mentor_Id,
                        principalTable: "Mentor",
                        principalColumn: "Mentor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_Skills_Skill_Id",
                        column: x => x.Skill_Id,
                        principalTable: "Skills",
                        principalColumn: "Skill_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Training_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Payment_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<long>(nullable: false),
                    Mentor_Id = table.Column<long>(nullable: false),
                    Training_Id = table.Column<long>(nullable: false),
                    Payment_Amount = table.Column<double>(nullable: false),
                    Skill_Name = table.Column<string>(nullable: false),
                    Mentor_Amount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_Mentor_Id",
                        column: x => x.Mentor_Id,
                        principalTable: "Mentor",
                        principalColumn: "Mentor_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_Training_Training_Id",
                        column: x => x.Training_Id,
                        principalTable: "Training",
                        principalColumn: "Training_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_User_User_Id",
                        column: x => x.User_Id,
                        principalTable: "User",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Mentor_Id",
                table: "Payment",
                column: "Mentor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Training_Id",
                table: "Payment",
                column: "Training_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_User_Id",
                table: "Payment",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Mentor_Id",
                table: "Training",
                column: "Mentor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Skill_Id",
                table: "Training",
                column: "Skill_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Training_User_Id",
                table: "Training",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
