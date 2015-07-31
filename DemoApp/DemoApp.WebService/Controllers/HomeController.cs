using DemoApp.Persistence.Repository;
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
        IFilmRepository _filmRepo;

        public HomeController(IFilmRepository filmRepo)
        {
            this._filmRepo = filmRepo;
        }

        [HttpGet]
        [ActionName("test")]
        public IEnumerable<Film> GetAllFilms()
        {
            var filmList = new List<Film>();
            var entityList = _filmRepo.GetAll();
            foreach (var entity in entityList)
            {
                filmList.Add(new Film { 
                    Description = entity.Description,
                    FilmId = entity.FilmId,
                    LanguageId = entity.LanguageId,
                    LastUpdated = entity.LastUpdated,
                    Length = entity.Length,
                    RatingMpaaRating = entity.RatingMpaaRating,
                    ReleaseYear = entity.ReleaseYear,
                    RentalDuration = entity.RentalDuration,
                    RentalRate = entity.RentalRate,
                    ReplacementCost = entity.ReplacementCost,
                    SpecialFeatures = entity.SpecialFeatures,
                    Title = entity.Title
                });
            }

            return filmList;
        }
    }
}
