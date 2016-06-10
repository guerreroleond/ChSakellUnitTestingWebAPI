using ChSakellUnitTestingWebAPI.Domain;
using System.Linq;

namespace ChSakellUnitTestingWebAPI.Data.Infrastructure
{
    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(IDbFactory dbFactory)
           : base(dbFactory)
        { }

        public Blog GetBlogByName(string blogName)
        {
            var _blog = this.DbContext.Blogs.Where(b => b.Name == blogName).FirstOrDefault();

            return _blog;
        }
    }
}
