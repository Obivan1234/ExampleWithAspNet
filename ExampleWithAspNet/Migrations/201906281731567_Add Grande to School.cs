namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGrandetoSchool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "Grande", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "Grande");
        }
    }
}
