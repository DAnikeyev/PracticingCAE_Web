using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticingCAE.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddPracticeProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attempts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OwnerId = table.Column<string>(type: "TEXT", nullable: false),
                    TaskId = table.Column<string>(type: "TEXT", nullable: false),
                    SetId = table.Column<string>(type: "TEXT", nullable: false),
                    ItemCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CorrectCount = table.Column<int>(type: "INTEGER", nullable: false),
                    HintUsed = table.Column<bool>(type: "INTEGER", nullable: false),
                    AnswersRevealed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TimestampUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attempts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeenSets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OwnerId = table.Column<string>(type: "TEXT", nullable: false),
                    TaskId = table.Column<string>(type: "TEXT", nullable: false),
                    SetId = table.Column<string>(type: "TEXT", nullable: false),
                    TimesSeen = table.Column<int>(type: "INTEGER", nullable: false),
                    LastSeenUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeenSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GapAnswers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AttemptId = table.Column<long>(type: "INTEGER", nullable: false),
                    GapIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    UserAnswer = table.Column<string>(type: "TEXT", nullable: false),
                    ExpectedAnswer = table.Column<string>(type: "TEXT", nullable: false),
                    IsCorrect = table.Column<bool>(type: "INTEGER", nullable: false),
                    HintShown = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GapAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GapAnswers_Attempts_AttemptId",
                        column: x => x.AttemptId,
                        principalTable: "Attempts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attempts_OwnerId_TaskId_TimestampUtc",
                table: "Attempts",
                columns: new[] { "OwnerId", "TaskId", "TimestampUtc" });

            migrationBuilder.CreateIndex(
                name: "IX_GapAnswers_AttemptId",
                table: "GapAnswers",
                column: "AttemptId");

            migrationBuilder.CreateIndex(
                name: "IX_SeenSets_OwnerId_TaskId_SetId",
                table: "SeenSets",
                columns: new[] { "OwnerId", "TaskId", "SetId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GapAnswers");

            migrationBuilder.DropTable(
                name: "SeenSets");

            migrationBuilder.DropTable(
                name: "Attempts");
        }
    }
}
