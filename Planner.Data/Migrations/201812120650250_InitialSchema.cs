namespace Planner.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 32),
                        LastName = c.String(maxLength: 32),
                        Name = c.String(maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Priority",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(maxLength: 500),
                        StartDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        EndDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        Priority = c.Int(),
                        Status = c.Int(),
                        AssignedTo = c.Int(nullable: false),
                        AssignedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        EstimatedTime = c.Int(nullable: false),
                        ActualTime = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.AssignedTo)
                .ForeignKey("dbo.Employee", t => t.AssignedBy)
                .ForeignKey("dbo.Priority", t => t.Priority)
                .ForeignKey("dbo.Status", t => t.Status)
                .Index(t => t.Priority)
                .Index(t => t.Status)
                .Index(t => t.AssignedTo)
                .Index(t => t.AssignedBy);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "Status", "dbo.Status");
            DropForeignKey("dbo.Task", "Priority", "dbo.Priority");
            DropForeignKey("dbo.Task", "AssignedBy", "dbo.Employee");
            DropForeignKey("dbo.Task", "AssignedTo", "dbo.Employee");
            DropForeignKey("dbo.Employee", "RoleId", "dbo.Role");
            DropIndex("dbo.Task", new[] { "AssignedBy" });
            DropIndex("dbo.Task", new[] { "AssignedTo" });
            DropIndex("dbo.Task", new[] { "Status" });
            DropIndex("dbo.Task", new[] { "Priority" });
            DropIndex("dbo.Employee", new[] { "RoleId" });
            DropTable("dbo.Task");
            DropTable("dbo.Status");
            DropTable("dbo.Priority");
            DropTable("dbo.Role");
            DropTable("dbo.Employee");
        }
    }
}
