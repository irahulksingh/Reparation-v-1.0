namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkOrders", "CustomerName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkOrders", "CustomerName", c => c.String());
        }
    }
}
