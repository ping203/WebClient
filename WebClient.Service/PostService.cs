using System.Collections.Generic;
using WebClient.Data.Infrastructure;
using WebClient.Data.Repositories;
using WebClient.Model.Models;

namespace WebClient.Service
{
    public interface IPostService
    {
        void Add(POST POST);

        void Update(POST POST);

        void Delete(int id);

        IEnumerable<POST> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<POST> GetAllByCategoryPaging(int page, int pageSize, out int totalRow);

        POST GetById(int id);

        IEnumerable<POST> GetAllByTagPaging(int tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }
    public class PostService:IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(POST post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<POST> GetAllByCategoryPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        public IEnumerable<POST> GetAllByTagPaging(int tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all post by tag
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);

        }

        public IEnumerable<POST> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public POST GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(POST post)
        {
            _postRepository.Update(post);
        }
    }
}
