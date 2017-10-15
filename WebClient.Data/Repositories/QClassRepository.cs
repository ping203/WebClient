using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IQClassRepository : IRepository<QClass>
    {
    }

    public class QClassRepository : RepositoryBase<QClass>, IQClassRepository
    {
        public QClassRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        
    }
}
