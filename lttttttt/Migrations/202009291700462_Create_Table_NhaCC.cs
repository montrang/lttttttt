namespace lttttttt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaCC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCCs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNCC = c.String(),
                        MaKhachhang = c.String(),
                    })
                .PrimaryKey(t => t.MaNCC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCCs");
        }
    }
}
