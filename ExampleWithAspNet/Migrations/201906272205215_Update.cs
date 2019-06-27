namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            
            DropColumn("dbo.Persons", "Region");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Persons", "Region", c => c.String());
            DropColumn("dbo.Persons", "Location");
        }
    }
}
