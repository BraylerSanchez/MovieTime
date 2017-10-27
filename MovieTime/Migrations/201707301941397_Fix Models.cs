namespace MovieTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Picture = c.Binary(nullable: false),
                        Description = c.String(),
                        Movie_MovieId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId)
                .Index(t => t.Movie_MovieId);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(nullable: false),
                        Description = c.String(),
                        Movie_MovieId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId)
                .Index(t => t.Movie_MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.Photos", "Movie_MovieId", "dbo.Movies");
            DropIndex("dbo.Videos", new[] { "Movie_MovieId" });
            DropIndex("dbo.Photos", new[] { "Movie_MovieId" });
            DropTable("dbo.Videos");
            DropTable("dbo.Photos");
        }
    }
}
