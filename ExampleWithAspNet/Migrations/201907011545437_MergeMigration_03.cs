namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MergeMigration_03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "FullName", c => c.String(nullable: false));
            AddColumn("dbo.Schools", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Persons", "Location", c => c.String());
            DropColumn("dbo.Schools", "KindOfSchool");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schools", "KindOfSchool", c => c.String());
            AlterColumn("dbo.Persons", "Location", c => c.String(nullable: false));
            DropColumn("dbo.Schools", "ZipCode");
            DropColumn("dbo.Persons", "FullName");
        }
    }
}
