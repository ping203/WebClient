using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IPageRepository : IRepository<PAGE>
    {
    }

    public class PageRepository : RepositoryBase<PAGE>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}