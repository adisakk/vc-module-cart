namespace VirtoCommerce.CartModule.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResizeLineItemProductOwner : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CartLineItem", "ProductOwner", c => c.String(maxLength: 64));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CartLineItem", "ProductOwner", c => c.String());
        }
    }
}
