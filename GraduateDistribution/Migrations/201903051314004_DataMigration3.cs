namespace GraduateDistribution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Specialties", "SpecialtyName", c => c.String());
            DropColumn("dbo.Groups", "GroupName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Groups", "GroupName", c => c.String());
            DropColumn("dbo.Specialties", "SpecialtyName");
        }
    }
}
