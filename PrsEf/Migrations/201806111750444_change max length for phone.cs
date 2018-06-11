namespace PrsEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changemaxlengthforphone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Phone", c => c.String(nullable: false, maxLength: 12));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Phone", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
