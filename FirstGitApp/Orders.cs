using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGitApp
{
	public class Orders
	{
		private string orderNumber;
		public DateTime orderDate;

		public Customer customer;
		public decimal amount;
	}

	public class OrdersV2:Orders
	{

	}
}
