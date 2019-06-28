namespace ExampleWithAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKindOfStudenttoStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "KindOfStudent", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "KindOfStudent");
        }
    }
}
