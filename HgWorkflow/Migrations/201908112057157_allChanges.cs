namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "AmountToBeCollected", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "AmountToBeCollected", c => c.Int(nullable: false));
        }
    }
}
