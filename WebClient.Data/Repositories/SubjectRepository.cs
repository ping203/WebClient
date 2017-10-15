
using System;
using System.Linq;
using WebClient.Data.Infrastructure;
using WebClient.Model.Models;

namespace WebClient.Data.Repositories
{
    public interface ISubjectRepositoty : IRepository<Subject>
    {
        string GetNameSubject(Guid subjectID); //cái này dùng để gọi lại để sử dụng thôi
    }

    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepositoty
    {
        public SubjectRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
        //hàm này dùng để lấy tên của môn học thông qua mã môn học đó
        //IEnumerable lấy tất cả các dữ liệu (lấy nguyên bảng luôn á) nào có mã đã truyền vào
        //nhưng thực tế thì mỗi mã chỉ có 1 tên thôi,, nhiều tên sẽ lỗi nên chỗ này mình k để là ienumerable
        //mà chỉ để là string thôi, vì sẽ xuất ra tên môn học đúng k, mà tên môn học là kiểu string nên ở đây mình để là string
        //public IEnumerable<Subject> GetNameSubject(Guid subjectID)//nên truyền mã môn học ở đây nè
        //{
        //    return this.DbContext.Subject.Where(x => x.SubjectID == subjectID);
        //}
        public string GetNameSubject(Guid subjectID)//nên truyền mã môn học ở đây nè
        {
            //vì do xuất ra chỉ 1 tên tương ứng thôi nên mình phải thêm singleordefault có nghĩa là sẽ xuất 1 giá trị hoặc
            //nếu k có giá trị thì nó sẽ xuất ra giá trị mặc định
            //giống như sql trong bảng xuất ra những row có giá trị subjectID trùng với mã truyền vào
            //và xuất ra tên đúng k, nên chỗ này mình phải truyền vô select
            //riêng với chỉ lấy 1 giá trị trong bảng thì mình dùng select (lưu ý i=> i. tức là subject i giống như đặt i thay thế cho tên subject á)
            //where với select k nên dùng tên giống nhau (x với i á, có thể dùng các từ ngữ khác để thay thế cũng đc
            //đối với xuất nhiều giá trị
            //VD: t muốn xuất tên môn học cùng với nội dung câu hỏi có mã subjectid truyền vào thì trong phâfn select làm như vầy
            //.select(i=>i new{i.descr, i.noOfQuestion}) ví dụ vậy
            return this.DbContext.Subject.Where(x => x.SubjectID == subjectID).Select(i => i.Descr).SingleOrDefault();
        }
    }
        
}
