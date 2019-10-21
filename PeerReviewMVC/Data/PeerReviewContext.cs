using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeerReviewMVC.Models;

namespace PeerReviewMVC.Data
{
    public class PeerReviewContext : DbContext
    {
        public PeerReviewContext (DbContextOptions<PeerReviewContext> options)
            : base(options)
        {
        }

        public DbSet<PeerReviewMVC.Models.Group> Group { get; set; }
    }
}
