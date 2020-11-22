using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer.Migrations.Internal;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore.Mvc.Extensions.Data.Migrations
{
    public class CompositeMigrationsAnnotationsProvider : IMigrationsAnnotationProvider
    {
        private readonly IMigrationsAnnotationProvider[] _providers;

        public CompositeMigrationsAnnotationsProvider(MigrationsAnnotationProviderDependencies dependencies)
        {
            _providers = new IMigrationsAnnotationProvider[] {
                new SqlServerMigrationsAnnotationProvider(dependencies),
                new MigrationsAnnotationProvider(dependencies)
            };
        }

        public IEnumerable<IAnnotation> ForRemove(IRelationalModel model) => _providers.SelectMany(p => p.ForRemove(model));

        public IEnumerable<IAnnotation> ForRemove(ITable table) => _providers.SelectMany(p => p.ForRemove(table));

        public IEnumerable<IAnnotation> ForRemove(IColumn column) => _providers.SelectMany(p => p.ForRemove(column));

        public IEnumerable<IAnnotation> ForRemove(IView view) => _providers.SelectMany(p => p.ForRemove(view));

        public IEnumerable<IAnnotation> ForRemove(IViewColumn column) => _providers.SelectMany(p => p.ForRemove(column));

        public IEnumerable<IAnnotation> ForRemove(IUniqueConstraint constraint) => _providers.SelectMany(p => p.ForRemove(constraint));

        public IEnumerable<IAnnotation> ForRemove(ITableIndex index) => _providers.SelectMany(p => p.ForRemove(index));

        public IEnumerable<IAnnotation> ForRemove(IForeignKeyConstraint foreignKey) => _providers.SelectMany(p => p.ForRemove(foreignKey));

        public IEnumerable<IAnnotation> ForRemove(ISequence sequence) => _providers.SelectMany(p => p.ForRemove(sequence));

        public IEnumerable<IAnnotation> ForRemove(ICheckConstraint checkConstraint) => _providers.SelectMany(p => p.ForRemove(checkConstraint));
    }
}
