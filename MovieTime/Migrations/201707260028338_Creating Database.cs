namespace MovieTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CustomerId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        SecondLastName = c.String(nullable: false, maxLength: 20),
                        IdType = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        City = c.String(nullable: false),
                        Sector = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        CivilStatus = c.String(nullable: false, maxLength: 20),
                        PrimaryPhone = c.String(nullable: false),
                        SecondaryPhone = c.String(),
                        CellPhone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Membership_MembershipId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Memberships", t => t.Membership_MembershipId)
                .Index(t => t.Membership_MembershipId);
            
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        MembershipId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SignUpFee = c.String(),
                        DurationInMonths = c.String(),
                        DiscountRate = c.String(),
                    })
                .PrimaryKey(t => t.MembershipId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        ReleaseDate = c.DateTime(nullable: false),
                        Country = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Duration = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        RankingIDMB = c.Double(nullable: false),
                        Directors = c.String(),
                        Writers = c.String(),
                        NumberInStock = c.Int(nullable: false),
                        NumberAvailable = c.Int(nullable: false),
                        Price = c.Double(),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MovieId)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Movie_MovieId = c.Int(),
                    })
                .PrimaryKey(t => t.GenderID)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieId)
                .Index(t => t.Movie_MovieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Genders", "Movie_MovieId", "dbo.Movies");
            DropForeignKey("dbo.Customers", "Membership_MembershipId", "dbo.Memberships");
            DropIndex("dbo.Genders", new[] { "Movie_MovieId" });
            DropIndex("dbo.Movies", new[] { "Customer_Id" });
            DropIndex("dbo.Customers", new[] { "Membership_MembershipId" });
            DropTable("dbo.Genders");
            DropTable("dbo.Movies");
            DropTable("dbo.Memberships");
            DropTable("dbo.Customers");
        }
    }
}
