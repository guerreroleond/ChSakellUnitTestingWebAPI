using ChSakellUnitTestingWebAPI.Data.Infrastructure;
using ChSakellUnitTestingWebAPI.Domain;
using System.Linq;

namespace ChSakellUnitTestingWebAPI.Data.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Article GetArticleByTitle(string title)
        {
            var _article = this.DbContext.Articles.Where(b => b.Title == title).FirstOrDefault();

            return _article;
        }
    }
}
