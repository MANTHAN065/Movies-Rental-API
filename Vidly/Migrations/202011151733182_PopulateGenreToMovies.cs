namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Titanic', 'Romantic/Drama')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Shutter Island',  'Thriller/Mystery')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Avengers: Endgame', 'Action/Sci-fi')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('2012', 'Thriller/Action')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Grown Ups', 'Comedy')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Project X', 'Comedy')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Hotel Transylvania', 'Family/Comedy')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Toy Story', 'Family/Comedy')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('The Conjuring 2', 'Horror/Thriller')");
            Sql("INSERT INTO MOVIES (Name, Genre) VALUES ('Leap Year', 'Romantic/Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
