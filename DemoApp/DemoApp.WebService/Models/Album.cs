﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.WebService.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        public int ArtistId { get; set; }
    }
}