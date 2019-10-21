using System;
using Microsoft.EntityFrameworkCore;
using PeerReviewMVC.Models;

namespace PeerReviewMVC.Data
{
    public class PeerReviewContext: DbContext
    {
        public PeerReviewContext(DbContextOptions<PeerReviewContext> options)
            : base(options)
        {
        }

        public DbSet<Group> Group { get; set; }
    }

}
