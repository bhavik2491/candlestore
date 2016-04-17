namespace MVC_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class no : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "no", c => c.String());
            AddColumn("dbo.Teachers", "no", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "no");
            DropColumn("dbo.Students", "no");
        }
    }
}
