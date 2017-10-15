using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private WebClientDbContext dbContext;
        public WebClientDbContext Init()
        {
            return dbContext ?? (dbContext = new WebClientDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
