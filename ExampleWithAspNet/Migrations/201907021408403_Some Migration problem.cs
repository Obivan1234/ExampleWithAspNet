namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeMigrationproblem : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persons", "Name", c => c.String());
            AlterColumn("dbo.Persons", "Age", c => c.Int());
            AlterColumn("dbo.Persons", "Gender", c => c.String());
            AlterColumn("dbo.Persons", "FullName", c => c.String());
            AlterColumn("dbo.Locations", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Persons", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Persons", "Gender", c => c.String(nullable: false));
            AlterColumn("dbo.Persons", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Persons", "Name", c => c.String(nullable: false));
        }
    }
}
