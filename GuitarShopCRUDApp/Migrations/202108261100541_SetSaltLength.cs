namespace GuitarShopCRUDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetSaltLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Salt", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Salt", c => c.String());
        }
    }
}
