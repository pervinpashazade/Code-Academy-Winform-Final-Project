﻿namespace LibraryFinalTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelStatusAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Status");
        }
    }
}
