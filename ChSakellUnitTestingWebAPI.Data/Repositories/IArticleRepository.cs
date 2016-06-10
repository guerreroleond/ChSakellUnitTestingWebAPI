using ChSakellUnitTestingWebAPI.Data.Infrastructure;
using ChSakellUnitTestingWebAPI.Domain;

namespace ChSakellUnitTestingWebAPI.Data.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleByTitle(string title);
    }
}