namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRegionFrompropertytoStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "RegionFrom", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "RegionFrom");
        }
    }
}
