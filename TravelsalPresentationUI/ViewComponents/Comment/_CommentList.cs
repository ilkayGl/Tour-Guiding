using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace TravelsalPresentationUI.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }


        public IViewComponentResult Invoke(int id)
        {
            ViewBag.c=_commentService.GetFilterList(id).Count;
            var values = _commentService.GetFilterList(id);
            return View(values);
        }
    }
}
