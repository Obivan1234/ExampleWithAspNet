namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletesomepropertyfromStudent : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "RegionFrom");
            DropColumn("dbo.Students", "KindOfStudent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "KindOfStudent", c => c.String(nullable: false));
            AddColumn("dbo.Students", "RegionFrom", c => c.String(nullable: false));
        }
    }
}
