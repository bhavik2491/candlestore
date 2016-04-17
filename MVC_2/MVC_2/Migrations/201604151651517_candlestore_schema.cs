namespace MVC_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class candlestore_schema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailsId = c.Int(nullable: false, identity: true),
                        OrdersId = c.Int(nullable: false),
                        CandlesId = c.Int(nullable: false),
                        DetailName = c.String(),
                        price = c.Single(nullable: false),
                        SKU = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailsId)
                .ForeignKey("dbo.Candles", t => t.CandlesId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrdersId, cascadeDelete: true)
                .Index(t => t.OrdersId)
                .Index(t => t.CandlesId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrdersId = c.Int(nullable: false, identity: true),
                        UsersId = c.Int(nullable: false),
                        amount = c.Single(nullable: false),
                        ShipName = c.String(),
                        ShipAddress = c.String(),
                        ShipAddress2 = c.String(),
                        ShipCity = c.String(),
                        ShipState = c.String(),
                        BillAddress = c.String(),
                        BillAddress2 = c.String(),
                        BillCity = c.String(),
                        BillState = c.String(),
                        OrderTax = c.Single(nullable: false),
                        Phone = c.String(),
                        Country = c.String(),
                        Email = c.String(),
                        Orderdate = c.String(),
                        OrderShipped = c.Int(nullable: false),
                        OrderTrackingNumber = c.String(),
                    })
                .PrimaryKey(t => t.OrdersId)
                .ForeignKey("dbo.Users", t => t.UsersId, cascadeDelete: true)
                .Index(t => t.UsersId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UsersId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        EmailVerified = c.Int(nullable: false),
                        Phone = c.String(),
                        Country = c.String(),
                        Address = c.String(),
                        Address2 = c.String(),
                        UserIp = c.String(),
                        creation_date = c.String(),
                    })
                .PrimaryKey(t => t.UsersId);
            
            AddColumn("dbo.Candles", "shortdecription", c => c.String());
            AddColumn("dbo.Candles", "Updatedate", c => c.String());
            AddColumn("dbo.Candles", "qty", c => c.Int(nullable: false));
            AddColumn("dbo.Candles", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Candles", "CategoryId");
            AddForeignKey("dbo.Candles", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UsersId", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "OrdersId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "CandlesId", "dbo.Candles");
            DropForeignKey("dbo.Candles", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "UsersId" });
            DropIndex("dbo.OrderDetails", new[] { "CandlesId" });
            DropIndex("dbo.OrderDetails", new[] { "OrdersId" });
            DropIndex("dbo.Candles", new[] { "CategoryId" });
            DropColumn("dbo.Candles", "CategoryId");
            DropColumn("dbo.Candles", "qty");
            DropColumn("dbo.Candles", "Updatedate");
            DropColumn("dbo.Candles", "shortdecription");
            DropTable("dbo.Users");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Categories");
        }
    }
}
