using System;
using System.Collections.Generic;

namespace PeerReviewMVC.Models
{
    public class Group
    {
        private List<User> users = new List<User>();
        private List<Assignment> instructions = new List<Assignment>();

        public int GroupId { get; set; }
        public List<User> Users { get{return users;} }
        public List<Assignment> Instructions { get { return instructions; } }
        String Name { get; set; }
    }
}
