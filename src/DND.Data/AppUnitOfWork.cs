using AspNetCore.Mvc.Extensions.Data.UnitOfWork;
using AspNetCore.Mvc.Extensions.DomainEvents;
using AspNetCore.Mvc.Extensions.Validation;
using DND.Application;
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
using System.Collections.Generic;

namespace DND.Data
{
    //Could also use IDbContext
    //The advantage of IAppUnitOfWork is that it can wrap multiple contexts and more importantly handles nested commits.
    public class AppUnitOfWork : UnitOfWorkWithEvents, IAppUnitOfWork
    {
        public IAuthorRepository AuthorRepository { get; }
        public IBlogPostRepository BlogPostRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public ILocationRepository LocationRepository { get; }
        public ITagRepository TagRepository { get; }

        public ICarouselItemRepository CarouselItemRepository { get; }
        public IContentHtmlRepository ContentHtmlRepository { get; }
        public IContentTextRepository ContentTextRepository { get; }
        public IFaqRepository FaqRepository { get; }
        public IMailingListRepository MailingListRepository { get; }
        public IProjectRepository ProjectRepository { get; }
        public ITestimonialRepository TestimonialRepository { get; }

        public AppUnitOfWork(
            IValidationService validationService, 
            IDomainEventBus domainEventBus, 
            AppContext appContext,
            IAuthorRepository authorRepository,
            IBlogPostRepository blogPostRepository,
            ICategoryRepository categoryRepository,
            ILocationRepository locationRepository,
            ITagRepository tagRepository,
            ICarouselItemRepository carouselItemRepository,
            IContentHtmlRepository contentHtmlRepository,
            IContentTextRepository contentTextRepository,
            IFaqRepository faqRepository,
            IMailingListRepository mailingListRepository,
            IProjectRepository projectRepository,
            ITestimonialRepository testimonialRepository
            )
            :base(true, validationService, domainEventBus, appContext)
        {
            AuthorRepository = authorRepository;
            BlogPostRepository = blogPostRepository;
            CategoryRepository = categoryRepository;
            LocationRepository = locationRepository;
            TagRepository = tagRepository;

            AddRepository(AuthorRepository);
            AddRepository(BlogPostRepository);
            AddRepository(CategoryRepository);
            AddRepository(LocationRepository);
            AddRepository(TagRepository);

            CarouselItemRepository = carouselItemRepository;
            ContentHtmlRepository = contentHtmlRepository;
            ContentTextRepository = contentTextRepository;
            FaqRepository = faqRepository;
            MailingListRepository = mailingListRepository;
            ProjectRepository = projectRepository;
            TestimonialRepository = testimonialRepository;

            AddRepository(CarouselItemRepository);
            AddRepository(ContentHtmlRepository);
            AddRepository(ContentTextRepository);
            AddRepository(FaqRepository);
            AddRepository(MailingListRepository);
            AddRepository(ProjectRepository);
            AddRepository(TestimonialRepository);
        }

        public override void InitializeRepositories(Dictionary<Type, DbContext> contextsByEntityType)
        {
            //Inject the repositories. It's better to inject them so the repos can then also be used in the Domain Services.

            //AuthorRepository = new AuthorRepository((AppContext)contextsByEntityType[typeof(Author)]);
        }
    }
}
