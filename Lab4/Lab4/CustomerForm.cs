using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
	public partial class CustomerForm : Form
	{
		Customer _customer;
		List<Performer> _performers;

		public CustomerForm(Customer customer)
		{
			InitializeComponent();
			_customer = customer;
			EditButton.Enabled = false;

			_performers = Performer.ReadPerformersList("performers");
			_performers.ForEach(performer =>
			{
				ListOfPerformers.Items.Add(performer.ToString());
			});

			if (_customer != null && _customer.ServiceOf != null && _customer.PerformerOfOrder != null)
			{
				ListOfPerformers.SelectedIndex = ListOfPerformers.Items.IndexOf(customer.PerformerOfOrder.ToString());
				ServiceOfText.Text = customer.ServiceOf;
				CustomerAddressText.Text = customer.CustomerAddress.ToString();
			}

		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Performer newPerformer = new Performer();
			PerformerForm performerForm = new PerformerForm(newPerformer);
			if (performerForm.ShowDialog() == DialogResult.OK)
			{
				ListOfPerformers.Items.Add(newPerformer.ToString());
				_performers.Add(newPerformer);
				Performer.WritePerformersToFile("performers", _performers);
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfPerformers.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _performers.Count)
			{
				MessageBox.Show("Choose performer");
				return;
			}
			PerformerForm performerModal = new PerformerForm(_performers[selectedIndex]);
			if (performerModal.ShowDialog() == DialogResult.OK)
			{
				ListOfPerformers.Items[selectedIndex] = _performers[selectedIndex].ToString();
				Performer.WritePerformersToFile("performers", _performers);
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfPerformers.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _performers.Count)
			{
				MessageBox.Show("Choose performer");
				return;
			}
			if (ServiceOfText.Text == "" || CustomerAddressText.Text == "")
			{
				MessageBox.Show("Fill empty fields");
				return;
			}
			_customer.PerformerOfOrder = _performers[selectedIndex];
			_customer.ServiceOf = ServiceOfText.Text;
			_customer.CustomerAddress = int.Parse(CustomerAddressText.Text);
			DialogResult = DialogResult.OK;
		}

		private void ListOfBureaus_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButton.Enabled = true;
		}

		private void CustomerInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_customer.PerformerOfOrder = _performers[ListOfPerformers.SelectedIndex];
					_customer.ServiceOf = ServiceOfText.Text;
					_customer.CustomerAddress = int.Parse(CustomerAddressText.Text);
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.Cancel;
				}
			}
		}

		private void CustomerAddressText_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
