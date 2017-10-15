using System;
using System.Collections.Generic;
using WebClient.Data.Infrastructure;
using WebClient.Data.Repositories;
using WebClient.Model.Models;

namespace WebClient.Service
{
    public interface ISubjectService
    {
        void addSubject(Subject q);
        void updateSubject(Subject q);
        void deleteSubject(int id);
        IEnumerable<Subject> getAll();
        void SaveChanges();
    }
    public class SubjectService:ISubjectService
    {
        ISubjectRepositoty _subject;
        IUnitOfWork _unitOfWork;
        public SubjectService(ISubjectRepositoty subjcect, IUnitOfWork unit)
        {
            this._subject = subjcect;
            this._unitOfWork = unit;
        }

        public void addSubject(Subject q)
        {
            _subject.Add(q);
        }

        public void deleteSubject(int id)
        {
            _subject.Delete(id);
        }

        public IEnumerable<Subject> getAll()
        {
            return _subject.GetAll(new string[] { "Subject" });
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void updateSubject(Subject q)
        {
            _subject.Update(q);
        }
    }
}
