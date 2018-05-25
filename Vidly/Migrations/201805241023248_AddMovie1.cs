namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Hangover', 5, 2017-11-03, 2013-05-03, 6)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'DieHard', 1, 2017-11-03, 2016-05-03, 6)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'The Terminator', 1, 2017-11-03, 2003-05-03, 6)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Toy Story', 3, 2017-11-03, 2005-05-03, 6)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Titanic', 4, 2017-11-03, 19978-05-03, 6)");
        }
        
        public override void Down()
        {
        }
    }
}
