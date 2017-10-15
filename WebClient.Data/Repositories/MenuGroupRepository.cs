using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MENUGROUP>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MENUGROUP>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
