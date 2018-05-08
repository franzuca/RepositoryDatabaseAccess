namespace RepositoryDatabaseAccess.WebAppDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TenantID = c.Long(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Company", t => t.TenantID)
                .Index(t => t.TenantID);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CompanyName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Currency",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CurrencySymbol = c.String(),
                        CurrencyName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "TenantID", "dbo.Company");
            DropIndex("dbo.Client", new[] { "TenantID" });
            DropTable("dbo.Currency");
            DropTable("dbo.Company");
            DropTable("dbo.Client");
        }
    }
}
