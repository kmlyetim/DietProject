using Fake.DAL.Entities;
using Fake.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.Business.Services
{
    public class MessageService
    {
        MessageRepository messageRepository;
        public MessageService()
        {
            messageRepository = new MessageRepository();
        }
        public Message GetMessageById(int id)
        {
            return messageRepository.GetMessageById(id);
        }
        public List<Message> GetMessageBySenderId(int id)
        {
            return messageRepository.GetMessagesBySenderId(id);
        }
        public List<Message> GetMessageByRecieverId(int id)
        {
            return messageRepository.GetMessagesByRecieverId(id);
        }
        public int GetRecieverByMessageId(int id)
        {
            return messageRepository.GetRecieverByMessageId(id);
        }
        public void DeleteMessage(Message message)
        {
            messageRepository.DeleteMessage(message);
        }
        public void AddMessage(Message message)
        {
            messageRepository.AddMessage(message);
        }
        public void UpdateMessage(Message message)
        {
            messageRepository.UpdateMessage(message);
        }
    }
}
