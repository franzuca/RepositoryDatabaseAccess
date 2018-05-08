namespace RepositoryDatabaseAccess.WebAppDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientNameMissing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "ClientName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "ClientName");
        }
    }
}
