using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class ShopContextSeed
    {
        public static async Task SeedAsync(ShopContext db)
        {
            await db.Database.MigrateAsync();

            if (await db.Categories.AnyAsync() || await db.Brands.AnyAsync() || await db.Products.AnyAsync())
                return;

            var category1 = new Category() { Name = "Man" };
            var category2 = new Category() { Name = "Woman" };
            var category3 = new Category() { Name = "Unisex" };

            var brand1 = new Brand() { Name = "Ray-Ban" };
            var brand2 = new Brand() { Name = "Gucci" };
            var brand3 = new Brand() { Name = "Prada" };
            var brand4 = new Brand() { Name = "Tom Ford" };

            db.AddRange(
                new Product() { Category = category2, Brand = brand1, Price = 130.40m, PictureUrl = "01.png", Name = "Ray-Ban Aviator Classic" },
                new Product() { Category = category2, Brand = brand1, Price = 158.40m, PictureUrl = "02.png", Name = "Ray-Ban Jackie Ohh II" },
                new Product() { Category = category2, Brand = brand1, Price = 198.40m, PictureUrl = "03.png", Name = "Ray-Ban Bill" },
                new Product() { Category = category2, Brand = brand1, Price = 130.40m, PictureUrl = "04.png", Name = "Ray-Ban Hexagonal Flat Lenses" },
                new Product() { Category = category1, Brand = brand1, Price = 093.40m, PictureUrl = "05.png", Name = "Ray-Ban Andera" },
                new Product() { Category = category1, Brand = brand1, Price = 142.40m, PictureUrl = "06.png", Name = "Ray-Ban RB3611" },
                new Product() { Category = category3, Brand = brand2, Price = 377.50m, PictureUrl = "07.png", Name = "Gucci GG0291S" },
                new Product() { Category = category1, Brand = brand2, Price = 324.00m, PictureUrl = "08.png", Name = "Gucci GG0463S" },
                new Product() { Category = category2, Brand = brand2, Price = 452.00m, PictureUrl = "09.png", Name = "Gucci GG1111S" },
                new Product() { Category = category2, Brand = brand3, Price = 364.00m, PictureUrl = "10.png", Name = "Prada PR 19ZS" },
                new Product() { Category = category3, Brand = brand3, Price = 346.00m, PictureUrl = "11.png", Name = "Prada Hot" },
                new Product() { Category = category1, Brand = brand4, Price = 540.00m, PictureUrl = "12.png", Name = "Tom Ford FT1003" }
                );
            await db.SaveChangesAsync();
        }
    }
}
