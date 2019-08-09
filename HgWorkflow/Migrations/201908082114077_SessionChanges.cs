namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SessionChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "WorkOrderId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "WorkOrderId", c => c.Int(nullable: false));
        }
    }
}
