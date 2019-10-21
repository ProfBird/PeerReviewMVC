using System;
using System.Collections.Generic;

namespace PeerReviewMVC.Models
{
    public class Group
    {
        private List<User> users = new List<User>();
        private List<Instructions> instructions = new List<Instructions>();

        public List<User> Users { get{return users;} }
        public List<Instructions> Instructions { get { return instructions; } }
        String Name { get; set; }
    }
}
