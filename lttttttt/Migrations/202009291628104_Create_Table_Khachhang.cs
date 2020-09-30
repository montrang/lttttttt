namespace lttttttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Khachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhangs",
                c => new
                    {
                        MaKhachhang = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKhachhang = c.String(),
                        Sodt = c.String(maxLength: 15, unicode: false),
                        Diachi = c.String(),
                    })
                .PrimaryKey(t => t.MaKhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhangs");
        }
    }
}
