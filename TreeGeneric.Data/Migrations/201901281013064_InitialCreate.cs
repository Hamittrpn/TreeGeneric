namespace TreeGeneric.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Owner = c.String(nullable: false, maxLength: 200),
                        TreeTypeId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        TreeName = c.String(nullable: false, maxLength: 200),
                        TreeDescription = c.String(),
                        TreePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlantingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.TreeTypes", t => t.TreeTypeId, cascadeDelete: true)
                .Index(t => t.TreeTypeId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Plantings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DonationId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        PlantingDate = c.DateTime(nullable: false),
                        Lat = c.String(nullable: false, maxLength: 200),
                        Long = c.String(nullable: false, maxLength: 200),
                        PlantingCode = c.String(nullable: false, maxLength: 200),
                        RegionId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Donations", t => t.DonationId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId)
                .Index(t => t.DonationId)
                .Index(t => t.UserId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 200),
                        LastName = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        IsEmailConfirmed = c.Boolean(nullable: false),
                        EmailConfirmationCode = c.String(nullable: false, maxLength: 200),
                        EmailConfirmationDate = c.DateTime(),
                        Gender = c.Int(),
                        BirthDate = c.DateTime(),
                        Phone = c.String(nullable: false, maxLength: 200),
                        UserType = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Photo = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        PlantingId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Plantings", t => t.PlantingId, cascadeDelete: true)
                .Index(t => t.PlantingId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        Photo = c.String(nullable: false, maxLength: 200),
                        Lat = c.String(nullable: false, maxLength: 200),
                        Long = c.String(nullable: false, maxLength: 200),
                        Capacity = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TreeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(),
                        Photo = c.String(nullable: false, maxLength: 200),
                        TreePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlantingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Commision = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        AvailabilityCount = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TreeTypeRegions",
                c => new
                    {
                        TreeType_Id = c.Int(nullable: false),
                        Region_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TreeType_Id, t.Region_Id })
                .ForeignKey("dbo.TreeTypes", t => t.TreeType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.Region_Id, cascadeDelete: true)
                .Index(t => t.TreeType_Id)
                .Index(t => t.Region_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donations", "TreeTypeId", "dbo.TreeTypes");
            DropForeignKey("dbo.Donations", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Plantings", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.TreeTypeRegions", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.TreeTypeRegions", "TreeType_Id", "dbo.TreeTypes");
            DropForeignKey("dbo.Posts", "PlantingId", "dbo.Plantings");
            DropForeignKey("dbo.Plantings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Plantings", "DonationId", "dbo.Donations");
            DropIndex("dbo.TreeTypeRegions", new[] { "Region_Id" });
            DropIndex("dbo.TreeTypeRegions", new[] { "TreeType_Id" });
            DropIndex("dbo.Posts", new[] { "PlantingId" });
            DropIndex("dbo.Plantings", new[] { "RegionId" });
            DropIndex("dbo.Plantings", new[] { "UserId" });
            DropIndex("dbo.Plantings", new[] { "DonationId" });
            DropIndex("dbo.Donations", new[] { "RegionId" });
            DropIndex("dbo.Donations", new[] { "TreeTypeId" });
            DropTable("dbo.TreeTypeRegions");
            DropTable("dbo.TreeTypes");
            DropTable("dbo.Regions");
            DropTable("dbo.Posts");
            DropTable("dbo.Users");
            DropTable("dbo.Plantings");
            DropTable("dbo.Donations");
        }
    }
}
