using System;
using System.Collections.Generic;

namespace PeerReviewMVC.Models
{
    public class Instructions
    {
        private List<Submission> submissions = new List<Submission>();

        public List<Submission> Submissions { get { return submissions; } }
        public Rubric EvalGuide { get; set; }
        public String Title { get; set; }  // Name of the assignment
        public String Text { get; set; }    // Text of the instructions
        public String FileName { get; set; }  // file attachment
        public DateTime DraftDue { get; set; }
        public DateTime EvalDue { get; set; }
        public DateTime FinalDue { get; set; }
    }
}
