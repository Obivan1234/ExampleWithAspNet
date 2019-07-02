namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocationmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Persons", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.Persons", "LocationId", c => c.Int());
            CreateIndex("dbo.Persons", "LocationId");
            AddForeignKey("dbo.Persons", "LocationId", "dbo.Locations", "Id");
            DropColumn("dbo.Persons", "Location");
            DropColumn("dbo.Persons", "MaleOrFemale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "MaleOrFemale", c => c.String(nullable: false));
            AddColumn("dbo.Persons", "Location", c => c.String(nullable: false));
            DropForeignKey("dbo.Persons", "LocationId", "dbo.Locations");
            DropIndex("dbo.Persons", new[] { "LocationId" });
            DropColumn("dbo.Persons", "LocationId");
            DropColumn("dbo.Persons", "Gender");
            DropTable("dbo.Locations");
        }
    }
}
