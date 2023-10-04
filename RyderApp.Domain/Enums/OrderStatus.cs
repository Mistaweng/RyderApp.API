using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enums
{
	public enum OrderStatus
	{
		OrderPlaced = 1,
		PendingConfirmation = 2,
		Accepted = 3,
		Inprogress = 4,
		Delivered =5
	}
}
