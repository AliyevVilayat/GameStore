using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamingStore.MVC.Migrations
{
    /// <inheritdoc />
    public partial class GamesTableDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
        INSERT INTO Games (ImgPath, Name, Price, Description, GameId,IsDeleted)
        VALUES 
        ('path/to/image1.jpg', 'Game 1', 59.99, 'An amazing game', 'G001',0),
        ('path/to/image2.jpg', 'Game 2', 39.99, 'Another awesome game', 'G002',0),
        ('path/to/image3.jpg', 'Game 3', 49.99, 'The best game of the year', 'G003',0);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
