using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EJob.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Envelope",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Codification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envelope", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Codification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DocuemntSendingMode = table.Column<int>(nullable: false),
                    ColorMode = table.Column<int>(nullable: false),
                    PrintingMode = table.Column<int>(nullable: false),
                    HasAdvertisingInsert = table.Column<bool>(nullable: false),
                    JobPipline = table.Column<int>(nullable: false),
                    PaperId = table.Column<int>(nullable: true),
                    EnvelopeId = table.Column<int>(nullable: true),
                    ProcessingDays = table.Column<int>(nullable: false),
                    ProductionDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Envelope_EnvelopeId",
                        column: x => x.EnvelopeId,
                        principalTable: "Envelope",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Paper_PaperId",
                        column: x => x.PaperId,
                        principalTable: "Paper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DocumentId = table.Column<int>(nullable: true),
                    ReceiptDate = table.Column<DateTime>(nullable: false),
                    ProcessingDate = table.Column<DateTime>(nullable: false),
                    ValidationDate = table.Column<DateTime>(nullable: false),
                    PageCount = table.Column<int>(nullable: false),
                    CustomerCount = table.Column<int>(nullable: false),
                    SheetCount = table.Column<int>(nullable: false),
                    PrintingFlowPath = table.Column<string>(nullable: true),
                    CustomProcessingDays = table.Column<int>(nullable: false),
                    CustomProductionDays = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spool",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PageCount = table.Column<int>(nullable: false),
                    CustomerCount = table.Column<int>(nullable: false),
                    SheetCount = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spool_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_EnvelopeId",
                table: "Documents",
                column: "EnvelopeId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PaperId",
                table: "Documents",
                column: "PaperId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_DocumentId",
                table: "Jobs",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Spool_JobId",
                table: "Spool",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spool");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Envelope");

            migrationBuilder.DropTable(
                name: "Paper");
        }
    }
}
