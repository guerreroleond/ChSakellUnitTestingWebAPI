using System;

namespace ChSakellUnitTestingWebAPI.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BloggerEntities Init();
    }
}
