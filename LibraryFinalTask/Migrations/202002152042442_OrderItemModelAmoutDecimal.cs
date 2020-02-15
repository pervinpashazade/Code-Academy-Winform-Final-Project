namespace LibraryFinalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderItemModelAmoutDecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrderItems", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "Amount", c => c.Int(nullable: false));
        }
    }
}
