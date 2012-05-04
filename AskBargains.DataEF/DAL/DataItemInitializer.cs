using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using AskBargains.DataEF.Models;

namespace AskBargains.DataEF.DAL
{
    public class DataItemInitializer: DropCreateDatabaseIfModelChanges<DataItemContext>
    {
         protected override void Seed(DataItemContext context)
         {
            var dataItems = new List<DataItem>
            {
                new DataItem(){BrandName = "Brand1", CompanyName = "Com1", Condition = "new", Content = "con1", CouponCode = "cou1", ExpireDate = "2012-12-31", ForwardLink = "Fwl1", ImgPath = "img1", ItemCategory = "cat1", ItemDescription = "des1", ItemName = "nam1", ItemPrice = "prc1", OriginalPrice = "orgp1", Promotion = "1", PublishDate = "2012-12-23", Rebate = "reb1", SKU = "sku1", Save = "sav1", Shipping = "shi1", ShowCoupons = "sho1", SubCategory = "sub1", Today = "today", UserRated = "rate", Warranty = "war1"},
                new DataItem(){BrandName = "Brand1", CompanyName = "Com1", Condition = "new", Content = "con1", CouponCode = "cou1", ExpireDate = "2012-12-31", ForwardLink = "Fwl1", ImgPath = "img1", ItemCategory = "cat1", ItemDescription = "des1", ItemName = "nam1", ItemPrice = "prc1", OriginalPrice = "orgp1", Promotion = "1", PublishDate = "2012-12-23", Rebate = "reb1", SKU = "sku1", Save = "sav1", Shipping = "shi1", ShowCoupons = "sho1", SubCategory = "sub1", Today = "today", UserRated = "rate", Warranty = "war1"},
                new DataItem(){BrandName = "Brand1", CompanyName = "Com1", Condition = "new", Content = "con1", CouponCode = "cou1", ExpireDate = "2012-12-31", ForwardLink = "Fwl1", ImgPath = "img1", ItemCategory = "cat1", ItemDescription = "des1", ItemName = "nam1", ItemPrice = "prc1", OriginalPrice = "orgp1", Promotion = "1", PublishDate = "2012-12-23", Rebate = "reb1", SKU = "sku1", Save = "sav1", Shipping = "shi1", ShowCoupons = "sho1", SubCategory = "sub1", Today = "today", UserRated = "rate", Warranty = "war1"},
                new DataItem(){BrandName = "Brand1", CompanyName = "Com1", Condition = "new", Content = "con1", CouponCode = "cou1", ExpireDate = "2012-12-31", ForwardLink = "Fwl1", ImgPath = "img1", ItemCategory = "cat1", ItemDescription = "des1", ItemName = "nam1", ItemPrice = "prc1", OriginalPrice = "orgp1", Promotion = "1", PublishDate = "2012-12-23", Rebate = "reb1", SKU = "sku1", Save = "sav1", Shipping = "shi1", ShowCoupons = "sho1", SubCategory = "sub1", Today = "today", UserRated = "rate", Warranty = "war1"},
                           
            };
             dataItems.ForEach(s => context.DataItems.Add(s));
             context.SaveChanges();

             var comments = new List<Comment>
            {
                new Comment(){CommentText =  "test1", DataItemId = 1, AddedOn = DateTime.Today, Commentator = "Unknown"},
                new Comment(){CommentText =  "test2", DataItemId = 1, AddedOn = DateTime.Today, Commentator = "Unknown"},
                new Comment(){CommentText =  "test3", DataItemId = 1, AddedOn = DateTime.Today, Commentator = "Unknown"},
                new Comment(){CommentText =  "test4", DataItemId = 2, AddedOn = DateTime.Today, Commentator = "Unknown"},
                new Comment(){CommentText =  "test5", DataItemId = 2, AddedOn = DateTime.Today, Commentator = "Unknown"},
               
            };
             comments.ForEach(s => context.Comments.Add(s));
             context.SaveChanges();
         }
    }
}
