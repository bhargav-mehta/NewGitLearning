﻿using System;
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

        public string version;
	}

	public class OrdersV2:Orders
	{

	}

	public class OrdersV3 : OrdersV2
	{

	}

	public class OrdersV4 : OrdersV3
	{

	}
}
