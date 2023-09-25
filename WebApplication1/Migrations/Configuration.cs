namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Cryptography;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication1.Models.ApplicationDbContext";
        }

        protected override void Seed(WebApplication1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.News.AddRange(NewsList());
            context.SaveChanges();
        }

        protected List<Models.News> NewsList() {

            List<Models.News> myList = new List<Models.News>();

            for (int i = 0; i < 100; i++) {

                Models.News news = new Models.News
                {
                    DateTime = DateTime.Now,
                    Title = "Title " + new Random().Next(),
                    Article = "Article " + new Random().NextDouble()
                };
                myList.Add(news);
            }

            return myList;
        }
    }
}
