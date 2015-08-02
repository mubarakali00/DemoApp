using DemoApp.EfRepository.Repository;
using DemoApp.WebService.Models;
using System;
using System.Collections.Generic;
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
            var trackList = new List<Track>();
            var result = _repo.GetAll();
            foreach (var item in result)
            {
                trackList.Add(new Track(item));
            }
            return trackList;
        }
    }
}
