namespace MVC_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class candle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candles",
                c => new
                    {
                        CandlesId = c.Int(nullable: false, identity: true),
                        catagory = c.String(),
                        name = c.String(),
                        photo = c.Binary(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.CandlesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candles");
        }
    }
}
