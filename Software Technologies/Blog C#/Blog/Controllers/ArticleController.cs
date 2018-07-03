using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var db = new BlogDbContext())
            {
                var articles = db.Articles.Include(x => x.Author).ToList();
                return View(articles);
            }
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(x => x.Id == id).Include(x => x.Author).First();
                if (article == null)
                {
                    return HttpNotFound();
                }
                return View(article);
            }
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    var authorId = db.Users.First(x => x.UserName == this.User.Identity.Name).Id;
                    article.AuthorId = authorId;
                    db.Articles.Add(article);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List");
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(x => x.Id == id).Include(x => x.Author).First();
                if (!IsUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }
                if (article == null)
                {
                    return HttpNotFound();
                }
                return View(article);
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(x => x.Id == id).Include(x => x.Author).First();
                if (article == null)
                {
                    return HttpNotFound();
                }
                db.Articles.Remove(article);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var db = new BlogDbContext())
            {
                var article = db.Articles.Where(x => x.Id == id).Include(x => x.Author).First();
                if (!IsUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }
                if (article == null)
                {
                    return HttpNotFound();
                }
                var model = new ArticleViewModel();
                model.Id = article.Id;
                model.Content = article.Content;
                model.Title = article.Title;
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Edit(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BlogDbContext())
                {
                    var article = db.Articles.FirstOrDefault(x => x.Id == model.Id);
                    article.Title = model.Title;
                    article.Content = model.Content;
                    db.Entry(article).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List");
        }

        private bool IsUserAuthorizedToEdit(Article article)
        {
            var isAdmin = this.User.IsInRole("Admin");
            var isAuthor = article.IsAuthor(this.User.Identity.Name);

            return isAuthor || isAdmin;
        }
    }
}