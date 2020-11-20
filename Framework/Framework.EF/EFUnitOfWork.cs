using System;
using Framework.Core;
using Sample.Infrastructure.EF;

namespace Framework.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly SampleDbContext _sampleDbContext;

        public EFUnitOfWork(SampleDbContext sampleDbContext)
        {
            _sampleDbContext = sampleDbContext;
        }

        public void Begin()
        {
            _sampleDbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _sampleDbContext.SaveChanges();
            _sampleDbContext.Database.CommitTransaction();
        }

        public void Rollback()
        {
            _sampleDbContext.Database.RollbackTransaction();
        }
    }
}
