using Fake.DAL.Context;
using Fake.DAL.Entities;
using Fake.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.Repository
{
    public class MessageRepository
    {
        FakeContext db;
        public MessageRepository()
        {
            db= new FakeContext();
        }
        public Message GetMessageById(int id)
        {
            return db.Messages.Where(x => x.Id == id).FirstOrDefault();
        }
        public List<Message> GetMessagesBySenderId(int id)
        {
            return db.Messages.Where(x=>x.SenderId ==id).OrderByDescending(y=>y.MessageTime).ToList();
        }
        public List<Message> GetMessagesByRecieverId(int id)
        {
            return db.Messages.Where(x => x.ReceiverId == id).OrderByDescending(y => y.MessageTime).ToList();
        }
        public int GetRecieverByMessageId(int id)
        {
            return Convert.ToInt32(db.Messages.Where(x => x.Id == id).Select(y => new { y.ReceiverId }).FirstOrDefault());
        }
        public void DeleteMessage(Message message)
        {
            Message _message = db.Messages.Find(message.Id);
            db.Messages.Remove(_message);
            db.SaveChanges();
        }
        public void AddMessage(Message message)
        {
            db.Messages.Add(message);
            db.SaveChanges();
        }
        public void UpdateMessage(Message message)
        {
            Message willBeUpdated = GetMessageById(message.Id);
            db.Entry(willBeUpdated).CurrentValues.SetValues(message);
            db.SaveChanges();
        }
    }
}
