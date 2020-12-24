namespace Test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHD = c.Int(nullable: false, identity: true),
                        ThanhTien = c.Int(nullable: false),
                        KhachHang_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHang_id, cascadeDelete: true)
                .Index(t => t.KhachHang_id);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.Int(nullable: false, identity: true),
                        TenKH = c.String(),
                        SDT = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHang_id", "dbo.KhachHangs");
            DropIndex("dbo.HoaDons", new[] { "KhachHang_id" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
        }
    }
}
