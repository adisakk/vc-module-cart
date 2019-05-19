namespace VirtoCommerce.CartModule.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLineItemProductOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartLineItem", "ProductOwner", c => c.String(maxLength: 64));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartLineItem", "ProductOwner");
        }
    }
}
