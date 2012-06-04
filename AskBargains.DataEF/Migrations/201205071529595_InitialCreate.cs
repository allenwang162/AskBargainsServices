namespace AskBargains.DataEF.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DataItem",
                c => new
                    {
                        DataItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ImgPath = c.String(),
                        CompanyName = c.String(),
                        ItemDescription = c.String(),
                        ForwardLink = c.String(),
                        CouponCode = c.String(),
                        OriginalPrice = c.String(),
                        ItemPrice = c.String(),
                        PublishDate = c.String(),
                        ExpireDate = c.String(),
                        ItemCategory = c.String(),
                        SubCategory = c.String(),
                        BrandName = c.String(),
                        SKU = c.String(),
                        ShowCoupons = c.String(),
                        Content = c.String(),
                        Promotion = c.String(),
                        Save = c.String(),
                        Rebate = c.String(),
                        Shipping = c.String(),
                        Condition = c.String(),
                        Warranty = c.String(),
                        UserRated = c.String(),
                        Today = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                        Others = c.String(),
                    })
                .PrimaryKey(t => t.DataItemId);
            
            CreateTable(
                "Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        DataItemId = c.Int(nullable: false),
                        CommentText = c.String(),
                        AddedOn = c.DateTime(nullable: false),
                        Commentator = c.String(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("DataItem", t => t.DataItemId, cascadeDelete: true)
                .Index(t => t.DataItemId);
            
        }
        
        public override void Down()
        {
            DropIndex("Comment", new[] { "DataItemId" });
            DropForeignKey("Comment", "DataItemId", "DataItem");
            DropTable("Comment");
            DropTable("DataItem");
        }
    }
}
