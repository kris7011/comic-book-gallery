using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository comicBookRepository = null;

        public ComicBooksController()
        {
            comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // you can also use var comicBook = comicBookRepository.GetComicBook((int)id); it do the same.
            var comicBook = comicBookRepository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}