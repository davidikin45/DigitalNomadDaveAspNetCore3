using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Users;
using AspNetCore.Mvc.Extensions.Validation;
using AspNetCore.Specification;
using AspNetCore.Specification.OrderByMapping;
using AutoMapper;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AspNetCore.Mvc.Extensions.Application
{
    public abstract class ApplicationServiceBase : IApplicationService
    {
        public IMapper Mapper { get; }
        public IUserService UserService { get; }
        public IValidationService ValidationService { get; }
        public IOrderByMapper OrderByMapper { get; }

        public ApplicationServiceBase(ApplicationServiceServicesContext context)
        {
            Mapper = context.Mapper;
            UserService = context.UserService;
            ValidationService = context.ValidationService;
            OrderByMapper = context.OrderByMapper;
        }

        public Expression<Func<TDestination, Object>>[] MapIncludes<TSource, TDestination>(Expression<Func<TSource, Object>>[] includes)
        {
            return Mapper.MapIncludes<TSource, TDestination>(includes);
        }

        public Expression<Func<TDestination, bool>> MapWhereClause<TSource, TDestination>(Expression<Func<TSource, bool>> selector)
        {
            return Mapper.MapWhereClause<TSource, TDestination>(selector);
        }

        public LambdaExpression MapWhereClause(Type source, Type destination, LambdaExpression selector)
        {
            return Mapper.MapWhereClause(source, destination, selector);
        }

        public Func<IQueryable<TDestination>, IOrderedQueryable<TDestination>> MapOrderBy<TSource, TDestination>(Expression<Func<IQueryable<TSource>, IOrderedQueryable<TSource>>> orderBy)
        {
            if (orderBy == null)
                return null;

            return Mapper.MapOrderBy<TSource, TDestination>(orderBy).Compile();
        }
    }
}
