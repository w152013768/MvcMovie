﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieIndex
    {
        public IList<Movie> Movies { get; set; }

        public SelectList Genres { get; set; }

        public string SelectedGenre { get; set; }

        public string SearchString { get; set; }
    }
}
