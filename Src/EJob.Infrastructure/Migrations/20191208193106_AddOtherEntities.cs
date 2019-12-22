using Microsoft.EntityFrameworkCore.Migrations;

namespace EJob.Infrastructure.Migrations
{
    public partial class AddOtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Envelope_EnvelopeId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Paper_PaperId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Spool_Jobs_JobId",
                table: "Spool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spool",
                table: "Spool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paper",
                table: "Paper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Envelope",
                table: "Envelope");

            migrationBuilder.RenameTable(
                name: "Spool",
                newName: "Spools");

            migrationBuilder.RenameTable(
                name: "Paper",
                newName: "Papers");

            migrationBuilder.RenameTable(
                name: "Envelope",
                newName: "Envelopes");

            migrationBuilder.RenameIndex(
                name: "IX_Spool_JobId",
                table: "Spools",
                newName: "IX_Spools_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spools",
                table: "Spools",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Papers",
                table: "Papers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Envelopes",
                table: "Envelopes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Envelopes_EnvelopeId",
                table: "Documents",
                column: "EnvelopeId",
                principalTable: "Envelopes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Papers_PaperId",
                table: "Documents",
                column: "PaperId",
                principalTable: "Papers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spools_Jobs_JobId",
                table: "Spools",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Envelopes_EnvelopeId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Papers_PaperId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Spools_Jobs_JobId",
                table: "Spools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spools",
                table: "Spools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Papers",
                table: "Papers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Envelopes",
                table: "Envelopes");

            migrationBuilder.RenameTable(
                name: "Spools",
                newName: "Spool");

            migrationBuilder.RenameTable(
                name: "Papers",
                newName: "Paper");

            migrationBuilder.RenameTable(
                name: "Envelopes",
                newName: "Envelope");

            migrationBuilder.RenameIndex(
                name: "IX_Spools_JobId",
                table: "Spool",
                newName: "IX_Spool_JobId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spool",
                table: "Spool",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paper",
                table: "Paper",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Envelope",
                table: "Envelope",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Envelope_EnvelopeId",
                table: "Documents",
                column: "EnvelopeId",
                principalTable: "Envelope",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Paper_PaperId",
                table: "Documents",
                column: "PaperId",
                principalTable: "Paper",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Spool_Jobs_JobId",
                table: "Spool",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
