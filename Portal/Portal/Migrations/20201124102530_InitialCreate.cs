﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_ID = table.Column<int>(nullable: false),
                    Last_Name = table.Column<string>(nullable: true),
                    First_Name = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
