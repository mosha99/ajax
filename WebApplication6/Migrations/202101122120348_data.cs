namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "email", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "email");
        }
    }
}
