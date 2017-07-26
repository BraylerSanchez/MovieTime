namespace MovieTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoleandusermodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        Role_RoleId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId)
                .Index(t => t.Role_RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_RoleId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Role_RoleId" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
