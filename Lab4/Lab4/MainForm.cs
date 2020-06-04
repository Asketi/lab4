using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
	public partial class MainForm : Form
	{
		private List<Bureau> _bureaus = new List<Bureau>();

		public MainForm()
		{
			InitializeComponent();
			EditButton.Enabled = false;
			InfoButton.Enabled = false;
			DeleteButton.Enabled = false;

			_bureaus = Bureau.ReadBureauList("bureaus");
			_bureaus.ForEach(bureauListInfo =>
			{
				ListOfBureaus.Items.Add(bureauListInfo.ToShortString());
			});
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Bureau bureau = new Bureau();
			BureauForm bureauForm = new BureauForm(bureau);
			if (bureauForm.ShowDialog() == DialogResult.OK)
			{
				ListOfBureaus.Items.Add(bureau.ToShortString());
				_bureaus.Add(bureau);
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (_bureaus != null)
			{
				Bureau.WriteBureausToFile("bureaus", _bureaus);
				MessageBox.Show("Saved successfully!");
			}
			else
			{
				MessageBox.Show("There are nothing to save");
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfBureaus.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _bureaus.Count)
			{
				MessageBox.Show("Choose bureau");
				return;
			}
			BureauForm bureauForm = new BureauForm(_bureaus[ListOfBureaus.SelectedIndex]);
			if (bureauForm.ShowDialog() == DialogResult.OK)
			{
				ListOfBureaus.Items[selectedIndex] = _bureaus[ListOfBureaus.SelectedIndex].ToShortString();
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void InfoButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfBureaus.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _bureaus.Count)
			{
				MessageBox.Show("Choose bureau");
			}
			else
			{
				MessageBox.Show(_bureaus[selectedIndex].ToString());
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfBureaus.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _bureaus.Count)
			{
				MessageBox.Show("Choose bureau");
				return;
			}
			_bureaus.RemoveAt(selectedIndex);
			ListOfBureaus.Items.RemoveAt(selectedIndex);
		}

		private void ListOfBureaus_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButton.Enabled = true;
			InfoButton.Enabled = true;
			DeleteButton.Enabled = true;
		}
	}
}
