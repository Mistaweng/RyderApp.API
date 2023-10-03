using RyderApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class MessageThreadParticipant : BaseEntity
	{
		public Guid AppUserId { get; set; }
        public bool IsPinned { get; set; }
        public bool IsArchived { get; set; }

        public DateTime LastReadTime { get; set; }
		public DateTime PinnedDate { get; set; }

		public MessageThread MessageThread { get; set; }
    }
}
