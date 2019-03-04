namespace GraduateDistribution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distributions",
                c => new
                    {
                        DistributionId = c.Int(nullable: false, identity: true),
                        DistributionStart = c.DateTime(nullable: false),
                        DistributionEnd = c.DateTime(nullable: false),
                        GraduateId = c.Int(nullable: false),
                        OrganizationId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistributionId)
                .ForeignKey("dbo.Graduates", t => t.GraduateId, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.GraduateId)
                .Index(t => t.OrganizationId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Graduates",
                c => new
                    {
                        GraduateId = c.Int(nullable: false, identity: true),
                        GraduateSurName = c.String(),
                        GraduateLastName = c.String(),
                        GraduateSecondName = c.String(),
                        GraduateBirthDate = c.String(),
                        GraduateGender = c.String(),
                        GraduateAdress = c.String(),
                        GraduateTelephone = c.String(),
                        GroupId = c.String(),
                        Group_GroupId = c.Int(),
                    })
                .PrimaryKey(t => t.GraduateId)
                .ForeignKey("dbo.Groups", t => t.Group_GroupId)
                .Index(t => t.Group_GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        GroupQuantity = c.Int(nullable: false),
                        GroupEndStudy = c.Int(nullable: false),
                        SpecialtyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroupId)
                .ForeignKey("dbo.Specialties", t => t.SpecialtyId, cascadeDelete: true)
                .Index(t => t.SpecialtyId);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        SpecialtyId = c.Int(nullable: false, identity: true),
                        SpecialtyCode = c.String(),
                        SpecialtyTime = c.String(),
                        SpecialtyFormStudy = c.String(),
                    })
                .PrimaryKey(t => t.SpecialtyId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        OrganizationId = c.Int(nullable: false, identity: true),
                        OrganizationName = c.String(),
                        OrganizationAdress = c.String(),
                        OrganizationTelephone = c.String(),
                        OrganizationSphere = c.String(),
                    })
                .PrimaryKey(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        PositionName = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Distributions", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Distributions", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Groups", "SpecialtyId", "dbo.Specialties");
            DropForeignKey("dbo.Graduates", "Group_GroupId", "dbo.Groups");
            DropForeignKey("dbo.Distributions", "GraduateId", "dbo.Graduates");
            DropIndex("dbo.Groups", new[] { "SpecialtyId" });
            DropIndex("dbo.Graduates", new[] { "Group_GroupId" });
            DropIndex("dbo.Distributions", new[] { "PositionId" });
            DropIndex("dbo.Distributions", new[] { "OrganizationId" });
            DropIndex("dbo.Distributions", new[] { "GraduateId" });
            DropTable("dbo.Positions");
            DropTable("dbo.Organizations");
            DropTable("dbo.Specialties");
            DropTable("dbo.Groups");
            DropTable("dbo.Graduates");
            DropTable("dbo.Distributions");
        }
    }
}
