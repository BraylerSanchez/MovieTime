namespace MovieTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTomatoesProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "RankingRottenTomatoes", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "RankingRottenTomatoes");
        }
    }
}
