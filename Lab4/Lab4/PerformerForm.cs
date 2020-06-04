using System;
using System.Windows.Forms;

namespace Lab4
{
	public partial class PerformerForm : Form
	{
		private Performer _performer;

		public PerformerForm(Performer performer)
		{
			InitializeComponent();

			_performer = performer;

			if (performer != null && performer.Name != null && performer.Surname != null && performer.Birthday != null)
			{
				PerformerNameText.Text = performer.Name;
				PerformerSurnameText.Text = performer.Surname;
				BirthdayText.Value = performer.Birthday;
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(PerformerNameText.Text) || string.IsNullOrEmpty(PerformerSurnameText.Text))
			{
				MessageBox.Show("Fill empty fields");
				return;
			}
			else
			{
				_performer.Name = PerformerNameText.Text;
				_performer.Surname = PerformerSurnameText.Text;
				_performer.Birthday = BirthdayText.Value;
				DialogResult = DialogResult.OK;
			}
		}

		private void PerformerForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_performer.Name = PerformerNameText.Text;
					_performer.Surname = PerformerSurnameText.Text;
					_performer.Birthday = BirthdayText.Value;
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.Cancel;
				}
			}
		}
	}
}
