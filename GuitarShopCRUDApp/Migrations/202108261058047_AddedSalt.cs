namespace GuitarShopCRUDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSalt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Salt", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Salt");
        }
    }
}
