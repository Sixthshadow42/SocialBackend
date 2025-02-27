﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialBackend.Data
{
    public class SocialBackendContext : DbContext
    {
        public SocialBackendContext (DbContextOptions<SocialBackendContext> options)
            : base(options)
        {
        }

        public DbSet<SocialBackend.Models.User> User { get; set; }

        public DbSet<SocialBackend.Models.Todo> Todo { get; set; }
    }
}
