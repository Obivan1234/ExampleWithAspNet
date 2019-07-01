namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaleOrFemaletoPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "MaleOrFemale", c => c.String(nullable: false));
            AlterColumn("dbo.Persons", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persons", "Location", c => c.String());
            DropColumn("dbo.Persons", "MaleOrFemale");
        }
    }
}
