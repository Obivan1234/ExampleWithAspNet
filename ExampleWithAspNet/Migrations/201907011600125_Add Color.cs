namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Color", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Color");
        }
    }
}
