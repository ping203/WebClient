using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface IQuestionRepository : IRepository<Question>
    {
    }

    public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
    {
        public QuestionRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

    }
}
