using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> GetList()
        {
            return _commentDal.List();
        }

        public List<Comment> GetFilterList(int id)
        {
            return _commentDal.FilterList(x => x.DestinationID == id);
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.Get(x => x.CommentID == id);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
