using Fake.DAL.Enums;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public MessageStatus MessageStatusForUser { get; set; }
        public MessageStatus MessageStatusForExpert { get; set; }
        public DateTime MessageTime { get; set; }
        public virtual User Sender { get; set; }
        public virtual User Receiver { get; set; }

    }
}
