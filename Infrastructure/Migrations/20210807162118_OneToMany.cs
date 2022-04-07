using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceAction_Services_ServiceId",
                table: "ServiceAction");

            migrationBuilder.DropIndex(
                name: "IX_ServiceAction_ServiceId",
                table: "ServiceAction");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "ServiceAction");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceActionId",
                table: "Services",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "Services",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceActionId",
                table: "Services",
                column: "ServiceActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceAction_ServiceActionId",
                table: "Services",
                column: "ServiceActionId",
                principalTable: "ServiceAction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceAction_ServiceActionId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceActionId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceActionId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Services");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                table: "ServiceAction",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceAction_ServiceId",
                table: "ServiceAction",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceAction_Services_ServiceId",
                table: "ServiceAction",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
