using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecsCore.Data.Migrations
{
    public partial class DebugToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntitySocialMedia",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntityRelationships",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntityPhone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntityNames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntityEmails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntityCreditCards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DebugToken",
                table: "EntityAddresses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntitySocialMedia");

            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntityRelationships");

            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntityPhone");

            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntityNames");

            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntityEmails");

            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntityCreditCards");

            migrationBuilder.DropColumn(
                name: "DebugToken",
                table: "EntityAddresses");
        }
    }
}
