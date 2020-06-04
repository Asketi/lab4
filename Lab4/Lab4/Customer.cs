using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4
{
	public class Customer : IXmlSerializable
	{
		private Performer _performerOfOrder;
		private string _serviceOf;
		private int _customerAddress;
		

		public Performer PerformerOfOrder { get { return _performerOfOrder; } set { _performerOfOrder = value; } }
		public string ServiceOf { get { return _serviceOf; } set { _serviceOf = value; } }
		public int CustomerAddress { get { return _customerAddress; } set { _customerAddress = value; } }
		


		public void ReadXml(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "Performer":
							_performerOfOrder = new Performer();
							_performerOfOrder.ReadXml(reader);
							break;

						case "ServiceOf":
							reader.Read();
							_serviceOf = reader.Value;
							break;

						case "CustomerAddress":
							reader.Read();
							_customerAddress = int.Parse(reader.Value);
							break;
					}
				}

				if (reader.Name.Equals("Customer"))
				{
					break;
				}
			}
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteStartElement("Customer");
			_performerOfOrder.WriteXml(writer);
			writer.WriteElementString("ServiceOf", _serviceOf);
			writer.WriteElementString("CustomerAddress", _customerAddress.ToString());
			writer.WriteEndElement();
		}

		public static List<Customer> ReadCustomers(XmlReader reader)
		{
			List<Customer> customers = new List<Customer>();
			reader.MoveToContent();
			while (reader.Read())
			{
				if (reader.IsStartElement() && !reader.Name.Equals("Customers"))
				{
					Customer customer = new Customer();
					customer.ReadXml(reader);
					customers.Add(customer);
				}
				else
				{
					break;
				}

			}
			return customers;
		}

		public override string ToString()
		{
			return $"{_performerOfOrder} {_serviceOf} {_customerAddress}";
		}

		public XmlSchema GetSchema()
		{
			return null;
		}
	}
}
