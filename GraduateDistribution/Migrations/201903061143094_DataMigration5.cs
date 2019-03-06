namespace GraduateDistribution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Graduates", "GraduateBirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Graduates", "GraduateBirthDate", c => c.String());
        }
    }
}
