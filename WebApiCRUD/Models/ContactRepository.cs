using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCRUD.Models
{
	public class ContactRepository
	{
		static Dictionary<int, Contact> data = new Dictionary<int, Contact>();



		public ContactRepository()
		{
			if (data.Count == 0)
			{
				for (int i = 1; i <= 5; i++)
				{
					data.Add(i, new Contact() {
						ContactId = i, 
						FirstName = "A" + i,
						LastName = "Z" + i,
						Email = "A"  + "Z" + i + "@google.com"
					});
				}
			}
		}



		public List<Contact> Contacts
		{
			get
			{
				return data.Values.ToList();
			}
		}

		public Contact GetById(int ContactId)
		{
			return data[ContactId];

		}
		public void Save(Contact c)
		{
			c.ContactId = data.Count + 1;
			data.Add(c.ContactId, c);

		}
		public void Update(Contact c)
		{
			data[c.ContactId] =  c;

		}


		public void Delete(int ContactId)
		{
			data.Remove(ContactId);

		}
	}
}