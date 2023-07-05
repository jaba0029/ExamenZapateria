namespace Zapateria_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zapateria1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Description = c.String(maxLength: 100),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalShelf = c.Int(nullable: false),
                        TotalVault = c.Int(nullable: false),
                        StoreId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stores", t => t.StoreId_Id)
                .Index(t => t.StoreId_Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "StoreId_Id", "dbo.Stores");
            DropIndex("dbo.Articles", new[] { "StoreId_Id" });
            DropTable("dbo.Stores");
            DropTable("dbo.Articles");
        }
    }
}
