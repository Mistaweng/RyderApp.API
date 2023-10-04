using RyderApp.Domain.Common;
using RyderApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class Rider : BaseEntity
	{
        public Guid AppUserId { get; set; }
        public string ValidIdUrl { get; set; }
        public string Passportphoto { get; set; }
        public string BikeDocument { get; set; }
        public RiderAvailabilityStatus AvailabilityStatus { get; set; }

    }
}
