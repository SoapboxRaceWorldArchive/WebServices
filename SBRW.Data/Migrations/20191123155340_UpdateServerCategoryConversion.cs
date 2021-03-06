﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SBRW.Data.Migrations
{
    public partial class UpdateServerCategoryConversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "servers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "servers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
