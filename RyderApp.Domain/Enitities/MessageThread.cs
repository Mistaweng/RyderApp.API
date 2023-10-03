using RyderApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class MessageThread : BaseEntity
	{
        public string Subject { get; set; }
        public Guid LastMessageId { get; set; }
        public Guid PinnedMessageId { get; set; }
    }
}
