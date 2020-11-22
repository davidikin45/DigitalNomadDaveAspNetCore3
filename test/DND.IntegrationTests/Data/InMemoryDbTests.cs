using AspNetCore.Mvc.Extensions.Data.Helpers;
using Autofac.AspNetCore.Extensions;
using Autofac.AspNetCore.Extensions.Data;
using Autofac.AspNetCore.Extensions.Data.IdentificationStrategies;
using DND.Data;
using DND.Data.Initializers;
using DND.Data.Repositories.Blog;
using DND.Data.Repositories.CMS;
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
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DND.IntegrationTests.Data
{
    public class InMemoryDbTests
    {
        private readonly ITestOutputHelper _output;

        public InMemoryDbTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task InMemoryTest()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<AppContext>>(sp => new DummyTenantDbContext<AppContext>());
            var tenant = new Tenant("", new ConfigurationBuilder().Build());
            ITenantService tenantService = new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), tenant);

            var options = DbContextConnections.DbContextOptionsInMemory<AppContext>("", log => _output.WriteLine(log));
            using (var context = new AppContext(options, tenantService))
            {

                IAuthorRepository authorRepository = new AuthorRepository(context);
                IBlogPostRepository blogPostRepository = new BlogPostRepository(context);
                ICategoryRepository categoryRepository = new CategoryRepository(context);
                ILocationRepository locationRepository = new LocationRepository(context);
                ITagRepository tagRepository = new TagRepository(context);
                ICarouselItemRepository carouselItemRepository = new CarouselItemRepository(context);
                IContentHtmlRepository contentHtmlRepository = new ContentHtmlRepository(context);
                IContentTextRepository contentTextRepository = new ContentTextRepository(context);
                IFaqRepository faqRepository = new FaqRepository(context);
                IMailingListRepository mailingListRepository = new MailingListRepository(context);
                IProjectRepository projectRepository = new ProjectRepository(context);
                ITestimonialRepository testimonialRepository = new TestimonialRepository(context);

                var uow = new AppUnitOfWork(null, null, context,
                    authorRepository,
                    blogPostRepository,
                    categoryRepository,
                    locationRepository,
                    tagRepository,
                    carouselItemRepository,
                    contentHtmlRepository,
                    contentTextRepository,
                    faqRepository,
                    mailingListRepository,
                    projectRepository,
                    testimonialRepository
                    );

                var faq = new Faq() { Question = "test" };
                context.Faqs.Add(faq);
                await context.SaveChangesAsync();
            }

            using (var context = new AppContext(options, tenantService))
            {
                var count = await context.Faqs.CountAsync();
                Assert.Equal(1, count);

                var faq = await context.Faqs.FirstOrDefaultAsync(f => f.Question == "test");
                Assert.NotNull(faq);
            }
        }

        [Fact]
        public async Task InMemoryTestInitialization()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<AppContext>>(sp => new DummyTenantDbContext<AppContext>());
            var tenant = new Tenant("", new ConfigurationBuilder().Build());
            ITenantService tenantService = new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), tenant);

            var options = DbContextConnections.DbContextOptionsInMemory<AppContext>();

            using var context = new AppContext(options, tenantService);
            var dbInitializer = new AppContextInitializerDropCreate();
            await dbInitializer.InitializeAsync(context);
            await context.Database.EnsureDeletedAsync(); //Clears Db Data
            Assert.True(await context.Database.ExistsAsync());
        }
    }
}