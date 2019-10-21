using System;
using System.Collections.Generic;

namespace PeerReviewMVC.Models
{
    public class Submission
    {
        private List<User> users = new List<User>();  // could be a group submission
        private List<Evaluation> evaluations = new List<Evaluation>();

        public int SubmissionId { get; set; }
        public List<Evaluation> Evaluations { get { return evaluations; } }
        public List<User> Users { get{return users;} }
        public String Text { get; set; }
        public String FileName { get; set; }
        public DateTime submitted { get; set; }
    }
}
