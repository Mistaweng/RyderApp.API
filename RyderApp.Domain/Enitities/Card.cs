using RyderApp.Domain.Common;
using RyderApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class Card : BaseEntity
	{
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public string CVV { get; set; }
        public string ExpiredOn { get; set; }
        public Guid AppUserId { get; set; }
        public CardStatus Status { get; set; }
    }
}
