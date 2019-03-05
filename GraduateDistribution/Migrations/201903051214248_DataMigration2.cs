namespace GraduateDistribution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Graduates", "Group_GroupId", "dbo.Groups");
            DropIndex("dbo.Graduates", new[] { "Group_GroupId" });
            DropColumn("dbo.Graduates", "GroupId");
            RenameColumn(table: "dbo.Graduates", name: "Group_GroupId", newName: "GroupId");
            AlterColumn("dbo.Graduates", "GroupId", c => c.Int(nullable: false));
            AlterColumn("dbo.Graduates", "GroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Graduates", "GroupId");
            AddForeignKey("dbo.Graduates", "GroupId", "dbo.Groups", "GroupId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Graduates", "GroupId", "dbo.Groups");
            DropIndex("dbo.Graduates", new[] { "GroupId" });
            AlterColumn("dbo.Graduates", "GroupId", c => c.Int());
            AlterColumn("dbo.Graduates", "GroupId", c => c.String());
            RenameColumn(table: "dbo.Graduates", name: "GroupId", newName: "Group_GroupId");
            AddColumn("dbo.Graduates", "GroupId", c => c.String());
            CreateIndex("dbo.Graduates", "Group_GroupId");
            AddForeignKey("dbo.Graduates", "Group_GroupId", "dbo.Groups", "GroupId");
        }
    }
}
