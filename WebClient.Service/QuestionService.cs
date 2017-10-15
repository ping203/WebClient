using WebClient.Data.Infrastructure;
using WebClient.Data.Repositories;
using WebClient.Model.Models;

namespace WebClient.Service
{
    public interface IQuestionService
    {
        void add(Question q);
        void update(Question q);
        void delete(int id);
        void SaveChanges();
    }
    public class QuestionService : IQuestionService
    {
        IQuestionRepository _question;
        IUnitOfWork _work;
        public QuestionService(IQuestionRepository question, IUnitOfWork work)
        {
            this._question = question;
            this._work = work;
        }
        public void add(Question q)
        {
            _question.Add(q);
        }

        public void delete(int id)
        {
            _question.Delete(id);
        }

        public void SaveChanges()
        {
            _work.Commit();
        }

        public void update(Question q)
        {
            _question.Update(q);
        }
    }
}
