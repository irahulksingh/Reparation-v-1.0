namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangetoWorkOrderModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "CustomerMobileNumber", c => c.String(nullable: false));
            AlterColumn("dbo.WorkOrders", "DateAcceptedOrRejected", c => c.DateTime());
            AlterColumn("dbo.WorkOrders", "ProductToBeReturnedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "ProductToBeReturnedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WorkOrders", "DateAcceptedOrRejected", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WorkOrders", "CustomerMobileNumber", c => c.String());
        }
    }
}
