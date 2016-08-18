using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_FinalExam.Models;

/* Name: Yandong Wang
 * Number: 200277628
 * Date: 8/18/2016
 * Version: 0.1
 * Description: Provide an Album List page,	an Artist list Page, and a Genre List page.
 */
namespace COMP2007_S2016_Lesson12C.Controllers
{

    public class StoreController : Controller
    {

        MVCMusicStoreContext storeDB = new MVCMusicStoreContext();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return View(genres);
        }


        public ActionResult Album()
        {
            List<Album> albums = storeDB.Albums.ToList();

            return View(albums);
        }

        public ActionResult Artist()
        {
            List<Artist> artists = storeDB.Artists.ToList();

            return View(artists);
        }




        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre = "Rock")
        {
            // Retrieve Genre and its Associated Albums from database
            Genre genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            Album album = storeDB.Albums.Find(id);

            return View(album);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();
            return PartialView(genres);
        }
    }
}