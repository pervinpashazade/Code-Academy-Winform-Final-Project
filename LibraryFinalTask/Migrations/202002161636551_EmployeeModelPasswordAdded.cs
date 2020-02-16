namespace LibraryFinalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeModelPasswordAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Password", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Password");
        }
    }
}
