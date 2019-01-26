namespace ListProductForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtabletblProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Image = c.String(maxLength: 255),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblProducts", "CategoryId", "dbo.tblCategories");
            DropIndex("dbo.tblProducts", new[] { "CategoryId" });
            DropTable("dbo.tblProducts");
        }
    }
}
