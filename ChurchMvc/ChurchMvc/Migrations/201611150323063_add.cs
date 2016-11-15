namespace ChurchMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupCustomers",
                c => new
                    {
                        Group_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Group_Id, t.Customer_Id })
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Group_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.GroupCustomers", "Group_Id", "dbo.Groups");
            DropIndex("dbo.GroupCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.GroupCustomers", new[] { "Group_Id" });
            DropTable("dbo.GroupCustomers");
            DropTable("dbo.Groups");
            DropTable("dbo.Customers");
        }
    }
}
