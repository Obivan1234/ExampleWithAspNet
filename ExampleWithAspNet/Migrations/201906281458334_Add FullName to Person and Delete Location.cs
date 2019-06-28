namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFullNametoPersonandDeleteLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "FullName", c => c.String(nullable: false));
            DropColumn("dbo.Students", "Occupation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Occupation", c => c.String(nullable: false));
            DropColumn("dbo.Persons", "FullName");
        }
    }
}
