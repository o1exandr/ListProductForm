namespace ListProductForm.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ListProductForm.Entities.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ListProductForm.Entities.EFContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            #region Add Categories
            context.Categories.AddOrUpdate(c=>c.Id,
                new Entities.Category
                {
                    Id=1,
                    Name="Ноутбуки",
                    Image=null
                });
            context.Categories.AddOrUpdate(c => c.Id,
                new Entities.Category
                {
                    Id = 2,
                    Name = "Відеокарти",
                    Image = null
                });
            #endregion

            #region Add Products
            context.Products.AddOrUpdate(c => c.Id,
                new Entities.Product
                {
                    Id = 1,
                    Name = "Ноутбук Dell XPS 13 9370 (X3716S3NIW-63S) Silver",
                    CategoryId=1,
                    Image = null
                });
            #endregion
        }
    }
}
