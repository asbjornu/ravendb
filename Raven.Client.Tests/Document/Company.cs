﻿using System.Collections.Generic;

namespace Raven.Client.Tests.Document
{
	public class Company
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public List<Contact> Contacts { get; set; }
		public int Phone { get; set; }
	}
}