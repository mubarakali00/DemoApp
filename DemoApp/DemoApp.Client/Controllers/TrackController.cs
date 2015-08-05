using DemoApp.Model;
using DemoApp.Repository.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Client.Controllers
{
    public class TrackController : Controller
    {
        ITrackRepository _repoTrack;
        private JsonSerializerSettings _camelCaseFormatter;

        public TrackController(ITrackRepository repository)
        {
            this._repoTrack = repository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllTracks()
        {
            var list = new List<Track>();
            var data = _repoTrack.GetAll();

            foreach (var item in data)
            {
                list.Add(convertFromEntityToModel(item));
            }

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, Formatter),
                ContentType = "application/json"
            };

            return jsonResult;
        }

        public JsonSerializerSettings Formatter
        {
            get
            {
                _camelCaseFormatter = new JsonSerializerSettings();
                _camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
                return _camelCaseFormatter;
            }
        }

        private Track convertFromEntityToModel(DemoApp.Repository.Entity.Track track)
        {
            var model = new Track
            {
                Album = track.Album != null ? convertFromEntityToModel(track.Album) : new Album(),
                AlbumId = track.AlbumId,
                Byte = track.Byte,
                Composer = track.Composer,
                GenreId = track.GenreId,
                Millisecond = track.Millisecond,
                Name = track.Name,
                TrackId = track.TrackId,
                UnitPrice = track.UnitPrice
            };
            return model;
        }

        private Album convertFromEntityToModel(DemoApp.Repository.Entity.Album album)
        {
            var model = new Album
            {
                AlbumId = album.AlbumId,
                AlbumTitle = album.AlbumTitle,
                ArtistId = album.ArtistId,
            };
            return model;
        }
    }
}