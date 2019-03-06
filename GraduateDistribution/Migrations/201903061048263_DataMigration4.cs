namespace GraduateDistribution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Graduates", "GraduateFirstName", c => c.String());
            DropColumn("dbo.Graduates", "GraduateLastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Graduates", "GraduateLastName", c => c.String());
            DropColumn("dbo.Graduates", "GraduateFirstName");
        }
    }
}
