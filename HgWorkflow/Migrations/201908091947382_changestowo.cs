namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestowo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkOrders", "Comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkOrders", "Comments");
        }
    }
}
