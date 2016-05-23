namespace ChSakellUnitTestingWebAPI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        BloggerEntities dbContext;

        public BloggerEntities Init()
        {
            return dbContext ?? (dbContext = new BloggerEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

    }
}
