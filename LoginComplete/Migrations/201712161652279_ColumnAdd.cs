namespace LoginComplete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiteUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiteUsers");
        }
    }
}
