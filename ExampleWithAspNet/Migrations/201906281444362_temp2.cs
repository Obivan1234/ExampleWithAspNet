namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temp2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Location");
        }
    }
}
