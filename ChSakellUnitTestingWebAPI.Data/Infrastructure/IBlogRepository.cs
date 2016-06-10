using ChSakellUnitTestingWebAPI.Domain;

namespace ChSakellUnitTestingWebAPI.Data.Infrastructure
{
    public interface IBlogRepository
    {
        Blog GetBlogByName(string blogName);
    }
}