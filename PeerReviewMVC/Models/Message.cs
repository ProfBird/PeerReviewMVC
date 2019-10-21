using System;
namespace PeerReviewMVC.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public Group ToGroup { get; set; }
        public String Text { get; set; }
    }
}
