namespace WpfGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabletblPictures : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblPictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 500),
                        Category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblPictures");
        }
    }
}
