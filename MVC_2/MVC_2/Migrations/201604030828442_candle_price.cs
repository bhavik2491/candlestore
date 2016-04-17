namespace MVC_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class candle_price : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candles", "price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Candles", "price");
        }
    }
}
