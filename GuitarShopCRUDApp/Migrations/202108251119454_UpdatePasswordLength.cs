namespace GuitarShopCRUDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePasswordLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 64, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 60, unicode: false));
        }
    }
}
