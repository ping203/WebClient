using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
        {
        }

        public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
        {
            public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
            {
            }
        }
}
