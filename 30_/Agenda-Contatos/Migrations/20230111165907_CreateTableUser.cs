﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContatos.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profile = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registerDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
