namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenderproperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Persons", "Gender", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Persons", "Gender", c => c.String());
        }
    }
}
