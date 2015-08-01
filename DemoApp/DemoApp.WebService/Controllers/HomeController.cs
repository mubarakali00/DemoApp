using DemoApp.DAL.Context;
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
        public HomeController()
        {
        }

        [HttpGet]
        [ActionName("test")]
        public IEnumerable<Artist> GetAllFilms()
        {
            var artistList = new List<Artist>();

            using (var db = new DatabaseContext("TestDatabase"))
            {
                var q = from c in db.Artists
                        select c;

                foreach (var entity in q)
                {
                    artistList.Add(new Artist
                    {
                        ArtistId = entity.ArtistId,
                        ArtistName = entity.Name
                    });
                }
            }
            return artistList;
        }
    }
}
