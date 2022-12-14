using System;
using System.Collections.Generic;
using DAL.Entities.Common;
using DAL.Entities.Identity;
using DAL.Entities.Reports;

namespace DAL.Entities.Messages
{
    public class Message : BaseEntity
    {
        public DateTime DateSent { get; set; }
        public DateTime DateRead { get; set; }
        public bool IsRead { get; set; } = false;
        public bool SenderDeleted { get; set; } = false;
        public bool IsDeleted { get; set; } = false;
        public bool RecipentDeleted { get; set; } = false;
        public string Text { get; set; }
        public bool IsUpdated { get; set; } = false;
        public virtual User Sender { get; set; }
        public string SenderId { get; set; }
        public virtual User Reciver { get; set; }
        public string ReciverId { get; set; }
        public virtual ICollection<ReportMessage> ReportsMessage { get; set; }
    }
}