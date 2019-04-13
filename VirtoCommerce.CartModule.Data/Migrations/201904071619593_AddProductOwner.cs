namespace VirtoCommerce.CartModule.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartLineItem", "ProductOwner", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartLineItem", "ProductOwner");
        }
    }
}
