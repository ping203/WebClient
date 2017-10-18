using WebClient.Data.Infrastructure;
using WebClient.Data.Repositories;
using WebClient.Model.Models;

namespace WebClient.Service
{
    public interface IErrorService
    {
        Error CreateError(Error q);
        void Save();
    }
    public class ErrorService:IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRepository errorrepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorrepository;
            this._unitOfWork = unitOfWork;
        }

        public Error CreateError(Error q)
        {
           return _errorRepository.Add(q);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
