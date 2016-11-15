namespace ChurchMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delet : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GroupCustomers", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.GroupCustomers", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.GroupCustomers", new[] { "Group_Id" });
            DropIndex("dbo.GroupCustomers", new[] { "Customer_Id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupCustomers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GroupCustomers",
                c => new
                    {
                        Group_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Group_Id, t.Customer_Id });
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.GroupCustomers", "Customer_Id");
            CreateIndex("dbo.GroupCustomers", "Group_Id");
            AddForeignKey("dbo.GroupCustomers", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GroupCustomers", "Group_Id", "dbo.Groups", "Id", cascadeDelete: true);
        }
    }
}
