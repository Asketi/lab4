namespace Lab4
{
	partial class PerformerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.PerformerNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PerformerSurnameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthdayText = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Performer Name";
            // 
            // PerformerNameText
            // 
            this.PerformerNameText.Location = new System.Drawing.Point(14, 36);
            this.PerformerNameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PerformerNameText.Name = "PerformerNameText";
            this.PerformerNameText.Size = new System.Drawing.Size(403, 20);
            this.PerformerNameText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Performer Surname";
            // 
            // PerformerSurnameText
            // 
            this.PerformerSurnameText.Location = new System.Drawing.Point(14, 93);
            this.PerformerSurnameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PerformerSurnameText.Name = "PerformerSurnameText";
            this.PerformerSurnameText.Size = new System.Drawing.Size(403, 20);
            this.PerformerSurnameText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Birthday";
            // 
            // BirthdayText
            // 
            this.BirthdayText.Location = new System.Drawing.Point(14, 169);
            this.BirthdayText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthdayText.Name = "BirthdayText";
            this.BirthdayText.Size = new System.Drawing.Size(201, 20);
            this.BirthdayText.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 280);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 37);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PerformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 327);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BirthdayText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PerformerSurnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PerformerNameText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PerformerForm";
            this.Text = "Performer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PerformerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PerformerNameText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PerformerSurnameText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker BirthdayText;
		private System.Windows.Forms.Button SaveButton;
	}
}