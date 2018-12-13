namespace Planner.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskSchemaUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Task", new[] { "AssignedTo" });
            DropIndex("dbo.Task", new[] { "AssignedBy" });
            AlterColumn("dbo.Task", "AssignedTo", c => c.Int());
            AlterColumn("dbo.Task", "AssignedBy", c => c.Int());
            CreateIndex("dbo.Task", "AssignedTo");
            CreateIndex("dbo.Task", "AssignedBy");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Task", new[] { "AssignedBy" });
            DropIndex("dbo.Task", new[] { "AssignedTo" });
            AlterColumn("dbo.Task", "AssignedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Task", "AssignedTo", c => c.Int(nullable: false));
            CreateIndex("dbo.Task", "AssignedBy");
            CreateIndex("dbo.Task", "AssignedTo");
        }
    }
}
