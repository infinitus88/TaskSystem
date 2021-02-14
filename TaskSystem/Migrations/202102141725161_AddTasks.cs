namespace TaskSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Description = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tasks", new[] { "User_Id" });
            DropTable("dbo.Tasks");
        }
    }
}
