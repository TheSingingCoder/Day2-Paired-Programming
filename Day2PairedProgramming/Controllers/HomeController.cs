using Day2PairedProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2PairedProgramming.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Funk AtomicDog = new Funk();
            AtomicDog.Song = "Atomic Dog";
            AtomicDog.Artist = "George Clinton";
            AtomicDog.Year = 1992;

            Pop Bad = new Pop();
            Bad.Song = "Bad";
            Bad.Artist = "Micheal Jackson";
            Bad.Decade = 1980;

            RocknRoll HoundDog = new RocknRoll();
            HoundDog.Song = "Hound Dog";
            HoundDog.Artist = "Elvis Presley";
            HoundDog.Decade = 1950;

            RocknRoll DarkSide= new RocknRoll();
            DarkSide.Song = "Dark Side of the Moon";
            DarkSide.Artist = "Pink Floyd";
            DarkSide.Decade = 1970;

            Jazz SoWhat = new Jazz();
            SoWhat.Song = "So What?";
            SoWhat.Composer = "Miles Davis";
            SoWhat.Year = 1959;

            Classical MoonlightSonata = new Classical();
            MoonlightSonata.Song = "Moonlight Sonata";
            MoonlightSonata.Composer = "Beethoven";
            MoonlightSonata.Period = "Classical";

            Pop Happy = new Pop();
            Happy.Song = "Happy";
            Happy.Artist = "Pherrel Williams";
            Happy.Decade = 2010;

            List<Pop> PopSongs = new List<Pop>();
            PopSongs.Add(Happy);
            PopSongs.Add(Bad);

            List<RocknRoll> RockSongs = new List<RocknRoll>();
            RockSongs.Add(DarkSide);
            RockSongs.Add(HoundDog);

            IndexVM VM = new IndexVM();
            VM.PopSongs.Add(Happy);
            VM.PopSongs.Add(Bad);
            VM.RockSongs.Add(DarkSide);
            VM.RockSongs.Add(HoundDog);
            VM.JazzSong1 = SoWhat;
            VM.ClassicalSong1 = MoonlightSonata;
            VM.FunkSong1 = AtomicDog;

            return View(VM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}