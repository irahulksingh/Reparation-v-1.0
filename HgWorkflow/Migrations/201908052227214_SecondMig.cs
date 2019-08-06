namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkOrderId = c.Int(nullable: false),
                        GoldSmithName = c.String(),
                        CustomerName = c.String(),
                        CustomerMobileNumber = c.String(),
                        CustomerEmail = c.String(),
                        JewelleryDescription1 = c.String(),
                        JewelleryDescription2 = c.String(),
                        JewelleryDescription3 = c.String(),
                        WorkToBeDone = c.String(),
                        WorkToBeDone2 = c.String(),
                        WorkToBeDone3 = c.String(),
                        AgentName = c.String(),
                        ProductGivenOn = c.DateTime(nullable: false),
                        DateProposed = c.DateTime(nullable: false),
                        DateAcceptedOrRejected = c.DateTime(nullable: false),
                        ProductToBeReturnedOn = c.DateTime(nullable: false),
                        AmountToBeCollected = c.Int(nullable: false),
                        AmountEstimate = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkOrders");
        }
    }
}
