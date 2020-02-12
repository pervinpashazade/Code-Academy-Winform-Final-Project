namespace LibraryFinalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsDataAnnotationsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Employees", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Authors", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Authors", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Books", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Genres", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Languages", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Languages", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Employees", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Positions", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Positions", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.OrderItems", "OrderDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.OrderItems", "ReturnDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderItems", "ReturnDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OrderItems", "OrderDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Positions", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Positions", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Phone", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "Surname", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Customers", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Surname", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Languages", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Languages", "Name", c => c.String());
            AlterColumn("dbo.Genres", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Books", "Name", c => c.String());
            AlterColumn("dbo.Authors", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Authors", "Surname", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
            DropColumn("dbo.Employees", "CreatedAt");
            DropColumn("dbo.Orders", "CreatedAt");
        }
    }
}
