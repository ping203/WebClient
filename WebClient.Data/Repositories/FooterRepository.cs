using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IFooterRepository : IRepository<FOOTER>
    {
    }

    public class FooterRepository : RepositoryBase<FOOTER>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}