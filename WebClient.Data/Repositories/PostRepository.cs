using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IPostRepository : IRepository<POST>
    {
        IEnumerable<POST> GetAllByTag(int tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class PostRepository : RepositoryBase<POST>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<POST> GetAllByTag(int tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.POST
                        join pt in DbContext.POSTTAG
                        on p.ID equals pt.IDPost
                        where pt.IDTag == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;

            totalRow = query.Count();

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }
    }
}
