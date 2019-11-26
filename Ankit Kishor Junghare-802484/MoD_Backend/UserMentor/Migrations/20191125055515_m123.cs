using Microsoft.EntityFrameworkCore.Migrations;

namespace UserMentor.Migrations
{
    public partial class m123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mentor_To_Timeslot",
                table: "Training",
                newName: "Mentor_To_TimeSlot");

            migrationBuilder.RenameColumn(
                name: "Mentor_From_Timeslot",
                table: "Training",
                newName: "Mentor_From_TimeSlot");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mentor_To_TimeSlot",
                table: "Training",
                newName: "Mentor_To_Timeslot");

            migrationBuilder.RenameColumn(
                name: "Mentor_From_TimeSlot",
                table: "Training",
                newName: "Mentor_From_Timeslot");
        }
    }
}
