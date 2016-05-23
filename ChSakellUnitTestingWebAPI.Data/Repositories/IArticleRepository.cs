using ChSakellUnitTestingWebAPI.Data.Infrastructure;
using ChSakellUnitTestingWebAPI.Domain;

namespace ChSakellUnitTestingWebAPI.Data.Repositories
{
    internal interface IArticleRepository : IRepository<Article>
    {
        Article GetArticleByTitle(string title);
    }
}