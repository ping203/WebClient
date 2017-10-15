using System;
using System.Collections.Generic;
using WebClient.Data.Infrastructure;
using WebClient.Data.Repositories;
using WebClient.Model.Models;

namespace WebClient.Service
{
    public interface IQClassService
    {
        void addQClass(QClass q);
        void updateQClass(QClass q);
        void deleteQClass(int id);
        IEnumerable<QClass> getAll();
        void SaveChanges();
    }

    public class QClassService : IQClassService
    {
        IQClassRepository _qClass;
        IUnitOfWork _unitOfWork;
        public QClassService(IQClassRepository qclass, IUnitOfWork unit)
        {
            this._qClass = qclass;
            this._unitOfWork = unit;
        }

        public void addQClass(QClass q)
        {
            _qClass.Add(q);
        }

        public void deleteQClass(int id)
        {
            _qClass.Delete(id);
        }
        public void updateQClass(QClass q)
        {
            _qClass.Update(q);
        }
        public IEnumerable<QClass> getAll()
        {
            return _qClass.GetAll(new string[] { "QClass" });
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
