using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Sqlite.Metadata.Internal;
using Microsoft.EntityFrameworkCore.SqlServer.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Data.Migrations
{
    public class CompositeRelationalAnnotationsProvider : IRelationalAnnotationProvider
    {
        private readonly IRelationalAnnotationProvider[] _providers;

        public CompositeRelationalAnnotationsProvider(RelationalAnnotationProviderDependencies dependencies)
        {
#pragma warning disable EF1001 // Type or member is obsolete
            _providers = new IRelationalAnnotationProvider[] {
                new SqlServerAnnotationProvider(dependencies),
                new SqliteAnnotationProvider(dependencies)
            };
#pragma warning restore EF1001
        }

        public IEnumerable<IAnnotation> For(IRelationalModel model) => _providers.SelectMany(p => p.For(model));

        public IEnumerable<IAnnotation> For(ITable table) => _providers.SelectMany(p => p.For(table));

        public IEnumerable<IAnnotation> For(IColumn column) => _providers.SelectMany(p => p.For(column));

        public IEnumerable<IAnnotation> For(IView view) => _providers.SelectMany(p => p.For(view));

        public IEnumerable<IAnnotation> For(IViewColumn column) => _providers.SelectMany(p => p.For(column));

        public IEnumerable<IAnnotation> For(ISqlQuery sqlQuery) => _providers.SelectMany(p => p.For(sqlQuery));

        public IEnumerable<IAnnotation> For(ISqlQueryColumn column) => _providers.SelectMany(p => p.For(column));

        public IEnumerable<IAnnotation> For(IStoreFunction function) => _providers.SelectMany(p => p.For(function));

        public IEnumerable<IAnnotation> For(IFunctionColumn column) => _providers.SelectMany(p => p.For(column));

        public IEnumerable<IAnnotation> For(IUniqueConstraint constraint) => _providers.SelectMany(p => p.For(constraint));

        public IEnumerable<IAnnotation> For(ITableIndex index) => _providers.SelectMany(p => p.For(index));

        public IEnumerable<IAnnotation> For(IForeignKeyConstraint foreignKey) => _providers.SelectMany(p => p.For(foreignKey));

        public IEnumerable<IAnnotation> For(ISequence sequence) => _providers.SelectMany(p => p.For(sequence));

        public IEnumerable<IAnnotation> For(ICheckConstraint checkConstraint) => _providers.SelectMany(p => p.For(checkConstraint));
    }
}
