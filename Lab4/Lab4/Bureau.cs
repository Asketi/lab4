using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Lab4
{
	public class Bureau : IXmlSerializable
	{
		private Services _service;
		private string _BureauName;
		private List<Customer> _customers = new List<Customer>();
		private int _costOrder = 0;

		public Services Service { get { return _service; } set { _service = value; } }
		public string BureauName { get { return _BureauName; } set { _BureauName = value; } }
		public List<Customer> Customers { get { return _customers; } set { _customers = value; CalculateCostOrderAndPerformers(); } }
		public int CostOrder { get { return _costOrder; } set { _costOrder = value; } }

		public void AddCustomer(Customer customer)
		{
			if (_customers == null)
			{
				_customers = new List<Customer>();
			}
			_customers.Add(customer);
			_costOrder += customer.CustomerAddress;
		}

		public void CalculateCostOrderAndPerformers()
		{
			_costOrder = 0;
			if (_customers != null)
			{
				_customers.ForEach(order =>
				{
					_costOrder += order.CustomerAddress;
				});
			}
		}

		public void ReadXml(XmlReader reader)
		{
			reader.MoveToContent();
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "BureauName":
							reader.Read();
							_BureauName = reader.Value;
							break;

						case "Services":
							reader.Read();
							_service = (Services)Enum.Parse(typeof(Services), reader.Value);
							break;

						case "Customers":
							_customers = Customer.ReadCustomers(reader);
							CalculateCostOrderAndPerformers();
							break;
					}
				}
				if (reader.Name.Equals("Bureau"))
				{
					break;
				}
			}
		}

		public static List<Bureau> ReadBureauList(string fileName)
		{
			List<Bureau> bureaus = new List<Bureau>();
			if (File.Exists(fileName))
			{
				using (XmlReader reader = XmlReader.Create(fileName))
				{
					reader.MoveToContent();
					while (reader.Read())
					{
						if (reader.IsStartElement() && !reader.Name.Equals("Bureaus"))
						{
							Bureau bureau = new Bureau();
							bureau.ReadXml(reader);
							bureaus.Add(bureau);
						}
						else
						{
							break;
						}
					}
				}
			}
			return bureaus;
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteStartElement("Bureau");
			writer.WriteElementString("BureauName", _BureauName);
			writer.WriteElementString("Service", _service.ToString());
			writer.WriteStartElement("Customers");
			if (Customers != null)
			{
				Customers.ForEach(customer =>
				{
					customer.WriteXml(writer);
				});
			}
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public static void WriteBureausToFile(string fileName, List<Bureau> bureaus)
		{
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.OmitXmlDeclaration = false;
			settings.NewLineOnAttributes = true;
			settings.ConformanceLevel = ConformanceLevel.Auto;

			XmlWriter xmlWriter = XmlWriter.Create(fileName, settings);
			xmlWriter.WriteStartElement("Bureaus");
			bureaus.ForEach(bureau =>
			{
				bureau.WriteXml(xmlWriter);
			});
			xmlWriter.WriteEndElement();
			xmlWriter.Close();
		}

		public override string ToString()
		{
			return $"Name: {_BureauName}\ncost order: {_costOrder}\nService: {Enum.GetName(typeof(Services), _service)}";
		}

		public string ToShortString()
		{
			return $"Name: {_BureauName} Total cost order: {_costOrder}";
		}

		public XmlSchema GetSchema()
		{
			return null;
		}
	}
}
