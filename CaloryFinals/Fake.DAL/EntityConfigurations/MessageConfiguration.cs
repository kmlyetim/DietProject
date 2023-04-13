using Fake.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake.DAL.EntityConfigurations
{
    public class MessageConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageConfiguration() 
        {
            //Key

            HasKey(x => x.Id);


            //Connections

            HasRequired(x => x.Sender).WithMany(x => x.Sent).HasForeignKey(x => x.SenderId).WillCascadeOnDelete(false);
            HasRequired(x => x.Receiver).WithMany(x => x.Inbox).HasForeignKey(x => x.ReceiverId).WillCascadeOnDelete(false);

        }
    }
}
