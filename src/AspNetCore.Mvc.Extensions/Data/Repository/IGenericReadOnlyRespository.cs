using AspNetCore.Specification;
using AspNetCore.Specification.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Data.Repository
{
    public interface IGenericReadOnlyRepository<TEntity>
         where TEntity : class
    {
        IReadOnlyList<TEntity> SQLQuery(string query, params object[] paramaters);
        IReadOnlyList<TEntity> SQLQuery(FormattableString query);
        Task<IReadOnlyList<TEntity>> SQLQueryAsync(string query, params object[] paramaters);
        Task<IReadOnlyList<TEntity>> SQLQueryAsync(FormattableString query);

        IReadOnlyList<TEntity> GetAll(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null,
            int? take = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties);

        Task<IReadOnlyList<TEntity>> GetAllAsync(
                CancellationToken cancellationToken,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                int? skip = null,
                int? take = null,
                bool getFullGraph = false,
                params Expression<Func<TEntity, Object>>[] includeProperties)
                ;

        IReadOnlyList<TEntity> GetAllNoTracking(
          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
          int? skip = null,
          int? take = null,
          bool getFullGraph = false,
          params Expression<Func<TEntity, Object>>[] includeProperties);

        Task<IReadOnlyList<TEntity>> GetAllNoTrackingAsync(
                 CancellationToken cancellationToken,
                Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                int? skip = null,
                int? take = null,
                bool getFullGraph = false,
                params Expression<Func<TEntity, Object>>[] includeProperties)
                ;

        CountList<TEntity> Search(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           int? skip = null,
           int? take = null,
           bool getFullGraph = false,
           params Expression<Func<TEntity, Object>>[] includeProperties)
           ;

        Task<CountList<TEntity>> SearchAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null,
            int? take = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        CountList<TEntity> SearchNoTracking(
       Expression<Func<TEntity, bool>> filter = null,
       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
       int? skip = null,
       int? take = null,
        bool getFullGraph = false,
       params Expression<Func<TEntity, Object>>[] includeProperties)
       ;

        Task<CountList<TEntity>> SearchNoTrackingAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null,
            int? take = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        Expression<Func<TEntity, bool>> PredicateEntityById(object id);
        Expression<Func<TEntity, bool>> PredicateEntityByIds(IEnumerable<object> ids);
        Expression<Func<TEntity, bool>> PredicateEntityByStringContains(string values);
        Expression<Func<TEntity, bool>> PredicateEntityByOwner(string ownedBy);
        Expression<Func<TEntity, bool>> And(Expression<Func<TEntity, bool>> leftExpression, Expression<Func<TEntity, bool>> rightExpression);
        Expression<Func<TEntity, bool>> Or(Expression<Func<TEntity, bool>> leftExpression, Expression<Func<TEntity, bool>> rightExpression);

       SpecificationDbQuery<TEntity> SpecificationQuery();
       SpecificationDbQuery<TEntity> SpecificationQuery(
          IncludeSpecification<TEntity> includeSpecification,
          FilterSpecification<TEntity> filterSpecification,
          OrderBySpecification<TEntity> orderBySpecification,
          int? skip = null,
          int? take = null,
          bool getFullGraph = false);

        IReadOnlyList<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null,
            int? take = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        Task<IReadOnlyList<TEntity>> GetAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null,
            int? take = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        IReadOnlyList<TEntity> GetNoTracking(
          Expression<Func<TEntity, bool>> filter = null,
          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
          int? skip = null,
          int? take = null,
          bool getFullGraph = false,
          params Expression<Func<TEntity, Object>>[] includeProperties)
          ;

        Task<IReadOnlyList<TEntity>> GetNoTrackingAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            int? skip = null,
            int? take = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        TEntity GetOne(
            Expression<Func<TEntity, bool>> filter = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        Task<TEntity> GetOneAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        TEntity GetOneNoTracking(
        Expression<Func<TEntity, bool>> filter = null,
        bool getFullGraph = false,
        params Expression<Func<TEntity, Object>>[] includeProperties)
        ;

        Task<TEntity> GetOneNoTrackingAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        TEntity GetFirst(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        Task<TEntity> GetFirstAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        TEntity GetFirstNoTracking(
          Expression<Func<TEntity, bool>> filter = null,
          Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
          bool getFullGraph = false,
          params Expression<Func<TEntity, Object>>[] includeProperties)
          ;

        Task<TEntity> GetFirstNoTrackingAsync(
            CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        TEntity GetById(object id,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        Task<TEntity> GetByIdAsync(
            CancellationToken cancellationToken,
            object id,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;


        TEntity GetByIdNoTracking(
            object id,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
          ;

        Task<TEntity> GetByIdNoTrackingAsync(CancellationToken cancellationToken,
            object id,
            bool getFullGraph = false,
            params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        (TEntity Entity, int TotalCount) GetByIdWithPagedCollectionProperty(object id,
      string collectionExpression,
      string search = "",
      LambdaExpression filter = null,
      string orderBy = null,
      int? skip = null,
      int? take = null);

        Task<(TEntity Entity, int TotalCount)> GetByIdWithPagedCollectionPropertyAsync(CancellationToken cancellationToken,
            object id,
            string collectionExpression,
            string search = "",
            LambdaExpression filter = null,
            string orderBy = null,
            int? skip = null,
            int? take = null);

        IReadOnlyList<TEntity> GetByIds(IEnumerable<object> ids,
         bool getFullGraph = false,
         params Expression<Func<TEntity, Object>>[] includeProperties)
           ;

        Task<IReadOnlyList<TEntity>> GetByIdsAsync(CancellationToken cancellationToken,
            IEnumerable<object> ids,
         bool getFullGraph = false,
         params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        IReadOnlyList<TEntity> GetByIdsNoTracking(IEnumerable<object> ids,
         bool getFullGraph = false,
         params Expression<Func<TEntity, Object>>[] includeProperties)
       ;

        Task<IReadOnlyList<TEntity>> GetByIdsNoTrackingAsync(CancellationToken cancellationToken,
            IEnumerable<object> ids,
         bool getFullGraph = false,
         params Expression<Func<TEntity, Object>>[] includeProperties)
            ;

        int GetCount(Expression<Func<TEntity, bool>> filter = null)
            ;

        Task<int> GetCountAsync(CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null)
            ;

        bool Exists(Expression<Func<TEntity, bool>> filter = null)
            ;

        Task<bool> ExistsAsync(CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null)
            ;

        bool ExistsNoTracking(Expression<Func<TEntity, bool>> filter = null)
          ;

        Task<bool> ExistsNoTrackingAsync(CancellationToken cancellationToken,
            Expression<Func<TEntity, bool>> filter = null)
            ;

        bool Exists(object id)
         ;

        Task<bool> ExistsAsync(CancellationToken cancellationToken, object id)
           ;

        bool ExistsNoTracking(object id)
        ;

        Task<bool> ExistsNoTrackingAsync(CancellationToken cancellationToken, object id)
           ;

        bool ExistsById(object id)
        ;

        Task<bool> ExistsByIdAsync(CancellationToken cancellationToken,
            object id)
            ;

        bool ExistsByIdNoTracking(object id)
          ;

        Task<bool> ExistsByIdNoTrackingAsync(CancellationToken cancellationToken,
            object id)
            ;

    }
}
