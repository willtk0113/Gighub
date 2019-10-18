﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Gighub.Migrations
{
    public partial class PopulateGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Sql scripting
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rock')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Country')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Hip-hop')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genres WHERE ID IN (1,2,3,4,5)");
        }
    }
}
