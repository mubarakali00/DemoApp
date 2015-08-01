﻿using DemoApp.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Repository
{
    public class FilmRepository : GenericRepository<Film>, IFilmRepository
    {
        public FilmRepository(IDbContext context) : base(context)
        {

        }
    }
}
