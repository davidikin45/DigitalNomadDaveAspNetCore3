using AspNetCore.Mvc.Extensions.Data;
using Autofac.AspNetCore.Extensions;
using DND.Data.Configurations.Blog.Authors;
using DND.Data.Configurations.Blog.BlogPosts;
using DND.Data.Configurations.Blog.Categories;
using DND.Data.Configurations.Blog.Locations;
using DND.Data.Configurations.Blog.Tags;
using DND.Data.Configurations.CMS.CarouselItems;
using DND.Data.Configurations.CMS.ContentHtmls;
using DND.Data.Configurations.CMS.ContentTexts;
using DND.Data.Configurations.CMS.Faqs;
using DND.Data.Configurations.CMS.MailingLists;
using DND.Data.Configurations.CMS.Projects;
using DND.Data.Configurations.CMS.Testimonials;
using DND.Domain.Blog.Authors;
using DND.Domain.Blog.BlogPosts;
using DND.Domain.Blog.Categories;
using DND.Domain.Blog.Locations;
using DND.Domain.Blog.Tags;
using DND.Domain.CMS.CarouselItems;
using DND.Domain.CMS.ContentHtmls;
using DND.Domain.CMS.ContentTexts;
using DND.Domain.CMS.Faqs;
using DND.Domain.CMS.MailingLists;
using DND.Domain.CMS.Projects;
using DND.Domain.CMS.Testimonials;
using Microsoft.EntityFrameworkCore;
using System;

namespace DND.Data
{
    public class AppContext : DbContextBase
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogPostTag> BlogPostTags { get; set; }
        public DbSet<BlogPostLocation> BlogPostLocations { get; set; }
        public DbSet<Location> Locations { get; set; }

        public DbSet<CarouselItem> CarouselItems { get; set; }
        public DbSet<ContentHtml> ContentHtml { get; set; }
        public DbSet<ContentText> ContentText { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<MailingList> MailingList { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        public AppContext(ITenantService tenantService)
            :base(tenantService)
        {

        }

        public AppContext(DbContextOptions<AppContext> options , ITenantService tenantService) : base(options, tenantService)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BlogPostConfiguration());
            //builder.ApplyConfiguration(new BlogPostTagConfiguration());
            //builder.ApplyConfiguration(new BlogPostLocationConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new LocationConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());

            builder.ApplyConfiguration(new CarouselItemConfiguration());
            builder.ApplyConfiguration(new ContentHtmlConfiguration());
            builder.ApplyConfiguration(new ContentTextConfiguration());
            builder.ApplyConfiguration(new FaqConfiguration());
            builder.ApplyConfiguration(new MailingListConfiguration());
            builder.ApplyConfiguration(new ProjectConfiguration());
            builder.ApplyConfiguration(new TestimonialConfiguration());

            //Seed Data with EnsureCreated or Migrations
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.About, HTML = "<p>About Me</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.SideBarAbout, HTML = "<p>About Me</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.WorkWithMe, HTML = "<p>Work With Me</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.MyWebsite, HTML = "<p>My Website</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.Affiliates, HTML = "<p>Affiliates</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.Resume, HTML = "<p>Resume</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.Contact, HTML = "<p>Contact</p>", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.Head, HTML = "", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.Main, HTML = "", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
            builder.Entity<ContentHtml>().HasData(new ContentHtml() { Id = Constants.ContentHtml.PrivacyPolicy, HTML = "", CreatedOn = DateTime.Now, CreatedBy = "SYSTEM" });
        }

        public override void AddKeylessEntities(ModelBuilder builder)
        {
         
        }
    }
}
