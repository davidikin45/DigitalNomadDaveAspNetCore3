using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Cqrs;
using AspNetCore.Mvc.Extensions.DomainEvents;
using AspNetCore.Mvc.Extensions.IntegrationEvents;
using AspNetCore.Mvc.Extensions.OrderByMapping;
using AspNetCore.Mvc.Extensions.Settings;
using AspNetCore.Mvc.Extensions.StartupTasks;
using DND.Application;
using DND.Application.Blog.Authors.Services;
using DND.Application.Blog.BlogPosts.Services;
using DND.Application.Blog.Categories.Services;
using DND.Application.Blog.Locations.Services;
using DND.Application.Blog.Tags.Services;
using DND.Application.CMS.CarouselItems.Services;
using DND.Application.CMS.ContentHtmls.Services;
using DND.Application.CMS.ContentTexts.Services;
using DND.Application.CMS.Faqs.Services;
using DND.Application.CMS.MailingLists.Services;
using DND.Application.CMS.Projects.Services;
using DND.Application.CMS.Testimonials.Services;
using DND.Data;
using DND.Data.Identity;
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
using DND.Domain.Identity;
using EntityFrameworkCore.Initialization;
using Hangfire;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Web
{

    public class Startup : AppStartupMvcIdentity<IdentityContext, User>
    {
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IWebHostEnvironment hostingEnvironment)
            :base(configuration, hostingEnvironment)
        {
            
        }

        public override void AddDatabases(IServiceCollection services, ConnectionStrings connectionStrings, string identityConnectionString, string hangfireConnectionString, string defaultConnectionString)
        {
            services.AddDbContextNoSql<NoSqlContext>(connectionStrings["NoSqlConnection"]);
            services.AddDbContext<DND.Data.AppContext>(defaultConnectionString);
            services.AddDbContext<IdentityContext>(identityConnectionString);
        }

        public override void AddRepositories(IServiceCollection services)
        {
            services.AddRepository<IAuthorRepository, AuthorRepository>();
            services.AddRepository<IBlogPostRepository, BlogPostRepository>();
            services.AddRepository<ICategoryRepository, CategoryRepository>();
            services.AddRepository<ILocationRepository, LocationRepository>();
            services.AddRepository<ITagRepository, TagRepository>();

            services.AddRepository<ICarouselItemRepository, CarouselItemRepository>();
            services.AddRepository<IContentHtmlRepository, ContentHtmlRepository>();
            services.AddRepository<IContentTextRepository, ContentTextRepository>();
            services.AddRepository<IFaqRepository, FaqRepository>();
            services.AddRepository<IMailingListRepository, MailingListRepository>();
            services.AddRepository<IProjectRepository, ProjectRepository>();
            services.AddRepository<ITestimonialRepository, TestimonialRepository>();
        }

        public override void AddUnitOfWorks(IServiceCollection services)
        {
            services.AddUnitOfWork<IAppUnitOfWork, AppUnitOfWork>();
        }

        public override void AddApplicationServices(IServiceCollection services)
        {
            services.AddTransient<IAuthorApplicationService, AuthorApplicationService>();
            services.AddTransient<IBlogPostApplicationService, BlogPostApplicationService>();
            services.AddTransient<ICategoryApplicationService, CategoryApplicationService>();
            services.AddTransient<ILocationApplicationService, LocationApplicationService>();
            services.AddTransient<ITagApplicationService, TagApplicationService>();

            services.AddTransient<ICarouselItemApplicationService, CarouselItemApplicationService>();
            services.AddTransient<IContentHtmlApplicationService, ContentHtmlApplicationService>();
            services.AddTransient<IContentTextApplicationService, ContentTextApplicationService>();
            services.AddTransient<IFaqApplicationService, FaqApplicationService>();
            services.AddTransient<IMailingListApplicationService, MailingListApplicationService>();
            services.AddTransient<IProjectApplicationService, ProjectApplicationService>();
            services.AddTransient<ITestimonialApplicationService, TestimonialApplicationService>();
        }

        public override void AddDomainServices(IServiceCollection services)
        {

        }

        public override void AddDbStartupTasks(IServiceCollection services)
        {
            services.AddDbStartupTask<NoSqlContextInitializer>();
            services.AddDbStartupTask<ApplicationContextInitializer>();
            services.AddDbStartupTask<HangfireDbInitializer>();
            services.AddDbStartupTask<IdentityContextInitializer>();
        }

        public override void AddStartupTasks(IServiceCollection services)
        {
            services.AddStartupTask<HangfireScheduledJobs>();
            services.AddStartupTask<CqrsCommandsTask>();
            services.AddStartupTask<CqrsQueriesTask>();
            services.AddStartupTask<DomainEventsTask>();
            services.AddStartupTask<IntegrationEventsTask>();
        }

        public override void AddHostedServices(IServiceCollection services)
        {
            //services.AddHostedServiceCronJob<Job2>("* * * * *");
        }

        public override void AddHangfireJobServices(IServiceCollection services)
        {
            //services.AddHangfireJob<Job1>();
        }

        public override void AddHttpClients(IServiceCollection services)
        {

        }

        public override void AddgRPCClients(IServiceCollection services)
        {

        }

        public override void AddGraphQLSchemas(IEndpointRouteBuilder endpoints)
        {

        }

        public override void ConfigureOrderByMapper(OrderByMapperOptions options)
        {
            
        }

        public override void AddHealthChecks(IHealthChecksBuilder healthCheckBuilder)
        {
          
        }
    }

    public class HangfireScheduledJobs : StartupTaskBlocking
    {
        public HangfireScheduledJobs(IServiceProvider serviceProvider)
        : base(serviceProvider)
        {
           
        }

        public override int Order => 0;

        protected override Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            var recurringJobManager = scopedServiceProvider.GetRequiredService<IRecurringJobManager>();
            //_recurringJobManager.AddOrUpdate("check-link", Job.FromExpression<Job1>(m => m.Execute()), Cron.Minutely(), new RecurringJobOptions());
            //_recurringJobManager.Trigger("check-link");

            return Task.CompletedTask;
        }
    }

    public class CqrsCommandsTask : StartupTaskBlocking
    {
        private readonly ICqrsMediator _mediator;

        public override int Order => 0;

        public CqrsCommandsTask(IServiceProvider serviceProvider, ICqrsMediator mediator)
             : base(serviceProvider)
        {
            _mediator = mediator;
        }

        protected override Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            _mediator.CqrsCommandSubscriptionManager.AddDynamicSubscription<object, CommandHandler>("*");
            return Task.CompletedTask;
        }
    }

    public class CqrsQueriesTask : StartupTaskBlocking
    {
        private readonly ICqrsMediator _mediator;

        public override int Order => 0;

        public CqrsQueriesTask(IServiceProvider serviceProvider, ICqrsMediator mediator)
             : base(serviceProvider)
        {
            _mediator = mediator;
        }

        protected override Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            _mediator.CqrsQuerySubscriptionManager.AddDynamicSubscription<object, QueryHandler>("*");
            return Task.CompletedTask;
        }
    }

    public class DomainEventsTask : StartupTaskBlocking
    {
        private readonly IDomainEventBus _eventBus;

        public override int Order => 0;

        public DomainEventsTask(IServiceProvider serviceProvider, IDomainEventBus eventBus)
             : base(serviceProvider)
        {
            _eventBus = eventBus;
        }

        protected override Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            _eventBus.DomainEventSubscriptionsManager.AddDynamicSubscription<DomainEventHandler>("*");
            return Task.CompletedTask;
        }
    }

    public class IntegrationEventsTask : StartupTaskBlocking
    {
        private readonly IIntegrationEventBus _eventBus;

        public override int Order => 0;

        public IntegrationEventsTask(IServiceProvider serviceProvider, IIntegrationEventBus eventBus)
             : base(serviceProvider)
        {
            _eventBus = eventBus;
        }

        protected override Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }
    }
}
