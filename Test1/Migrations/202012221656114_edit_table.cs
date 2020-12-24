namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "Email", c => c.String(nullable: false));
            AddColumn("dbo.KhachHangs", "PW", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "PW");
            DropColumn("dbo.KhachHangs", "Email");
        }
    }
}
