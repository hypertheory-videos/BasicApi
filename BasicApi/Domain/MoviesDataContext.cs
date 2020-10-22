﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicApi.Domain
{
    public class MoviesDataContext : DbContext
    {

        public MoviesDataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}
