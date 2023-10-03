using RyderApp.Domain.Common;
using RyderApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class Order : BaseEntity
	{
        public Guid RiderId { get; set; }
        public string PickUpPhoneNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Amount { get; set; }
        public OrderStatus Status { get; set; }
        public Address PickUpLocation { get; set; }
        public Address DropOffLocation { get; set; }

    }
}
