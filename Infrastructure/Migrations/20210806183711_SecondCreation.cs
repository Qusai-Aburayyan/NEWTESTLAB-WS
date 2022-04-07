﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SecondCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceAction_ServiceActionId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "ServiceAction");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceActionId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceActionId",
                table: "Services");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ServiceActionId",
                table: "Services",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ServiceAction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAction", x => x.Id);
                });

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
    }
}
