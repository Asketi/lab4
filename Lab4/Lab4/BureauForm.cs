using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class BureauForm : Form
	{
		public Bureau _bureau;

		public BureauForm(Bureau bureau)
		{
			InitializeComponent();
			_bureau = bureau;
			EditButton.Enabled = false;
			DeleteButton.Enabled = false;

			Services[] services = (Services[])Enum.GetValues(typeof(Services));
			foreach (Services service in services)
			{
				ServicesText.Items.Add(service.ToString());
			}
			if (_bureau != null && _bureau.BureauName != null && bureau.Service != null)
			{
				ServicesText.SelectedIndex = ServicesText.Items.IndexOf(bureau.Service.ToString());
				BureauNameText.Text = bureau.BureauName;
				_bureau.CalculateCostOrderAndPerformers();
				if (bureau.Customers != null)
				{
					bureau.Customers.ForEach(customer =>
					{
						ListOfCustomers.Items.Add(customer);
					});
				}
			}
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();
			CustomerForm customerForm = new CustomerForm(customer);
			if (customerForm.ShowDialog() == DialogResult.OK)
			{
				_bureau.AddCustomer(customer);
				_bureau.CalculateCostOrderAndPerformers();
				ListOfCustomers.Items.Add(customer.ToString());
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void ListOfBureaus_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButton.Enabled = true;
			DeleteButton.Enabled = true;
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfCustomers.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _bureau.Customers.Count)
			{
				MessageBox.Show("Choose customer");
				return;
			}
			CustomerForm customerForm = new CustomerForm(_bureau.Customers[selectedIndex]);
			if (customerForm.ShowDialog() == DialogResult.OK)
			{
				ListOfCustomers.Items[selectedIndex] = _bureau.Customers[selectedIndex].ToString();
				_bureau.CalculateCostOrderAndPerformers();
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			_bureau.BureauName = BureauNameText.Text;
			if (ServicesText.SelectedItem == null || BureauNameText.Text == "")
			{
				MessageBox.Show("Fill empty fields");
				return;
			}
			_bureau.Service = (Services)Enum.Parse(typeof(Services), ServicesText.SelectedItem.ToString());
			DialogResult = DialogResult.OK;
		}

		private void BureauForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_bureau.BureauName = BureauNameText.Text;
					_bureau.Service = (Services)Enum.Parse(typeof(Services), ServicesText.SelectedItem.ToString());
					_bureau.Customers = _bureau.Customers != null ? _bureau.Customers : null;
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.Cancel;
				}
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfCustomers.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _bureau.Customers.Count)
			{
				MessageBox.Show("Choose customer");
				return;
			}
			_bureau.Customers.RemoveAt(selectedIndex);
			ListOfCustomers.Items.RemoveAt(selectedIndex);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
