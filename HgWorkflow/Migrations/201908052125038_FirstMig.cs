namespace HgWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Anummer = c.String(nullable: false),
                        FullName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        confirmPassword = c.String(nullable: false),
                        ButikId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAccounts");
        }
    }
}
