using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsPortal.Model;

namespace NewsPortal.Data
{
    public class NewsPortalContext : DbContext
    {
        public NewsPortalContext (DbContextOptions<NewsPortalContext> options)
            : base(options)
        {
        }

        public DbSet<NewsPortal.Model.News> News { get; set; }
    }
}
