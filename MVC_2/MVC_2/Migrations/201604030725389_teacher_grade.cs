namespace MVC_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teacher_grade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "grade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "grade");
        }
    }
}
