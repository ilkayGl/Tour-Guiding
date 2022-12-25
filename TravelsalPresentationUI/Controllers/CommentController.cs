using AspNetCoreHero.ToastNotification.Abstractions;
using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TravelsalPresentationUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly INotyfService _notyf;


        public CommentController(ICommentService commentService, INotyfService notyf)
        {
            _commentService = commentService;
            _notyf = notyf;
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddComment(Comment comment)
        {
            //p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()); //Farklı bir yöntem
            //p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            //System.Threading.Thread.Sleep(2000);
            if (comment.CommentContent == null || comment.CommentUser == null)
            {
                _notyf.Warning("Yorum Alanını Boş Bırakamazsınız.");
                //_commentService.TAdd(comment);
                return Json(comment);

            }

            comment.Date = DateTime.Parse(DateTime.Now.ToString());
            comment.CommentSate = true;

            _commentService.TAdd(comment);
            _notyf.Success("Yorum Yaptınız");

            return Json(comment);

        }

    }
}
