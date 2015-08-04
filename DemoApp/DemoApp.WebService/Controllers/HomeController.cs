using DemoApp.Repository.Repository;
using DemoApp.WebService.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApp.WebService.Controllers
{

    public class HomeController : ApiController
    {
        ITrackRepository _repo;

        public HomeController(ITrackRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        [ActionName("test")]
        public IEnumerable<Track> GetAllFilms()
        {
            Stopwatch watch = new Stopwatch();
            var trackList = new List<Track>();

            watch.Start();
            var result = _repo.GetTrackWithAlbum();
            watch.Stop();

            Debug.Print("====== Data came from repository: " + watch.Elapsed.TotalSeconds);

            watch.Reset();
            watch.Start();
            foreach (var item in result)
            {
                trackList.Add(new Track(item));
            }
            watch.Stop();
            Debug.Print("\n====== Converted to Dao: " + watch.Elapsed.TotalSeconds);

            return trackList;
        }
    }
}
