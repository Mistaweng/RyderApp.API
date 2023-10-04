using RyderApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class Message : BaseEntity
	{
        public Guid MessageThreadId { get; set; }
        public Guid SenderId { get; set; } //This will be an app user Id
        public string Body { get; set; }    
    }
}
