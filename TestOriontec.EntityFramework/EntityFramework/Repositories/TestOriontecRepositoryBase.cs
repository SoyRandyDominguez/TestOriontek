using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TestOriontec.EntityFramework.Repositories
{
    public abstract class TestOriontecRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestOriontecDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestOriontecRepositoryBase(IDbContextProvider<TestOriontecDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestOriontecRepositoryBase<TEntity> : TestOriontecRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestOriontecRepositoryBase(IDbContextProvider<TestOriontecDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
