namespace Lab4
{
	partial class CustomerForm
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
            this.ServiceOfText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerAddressText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FeeText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ListOfPerformers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // ServiceOfText
            // 
            this.ServiceOfText.Location = new System.Drawing.Point(201, 11);
            this.ServiceOfText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServiceOfText.Name = "ServiceOfText";
            this.ServiceOfText.Size = new System.Drawing.Size(255, 20);
            this.ServiceOfText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Service";
            // 
            // CustomerAddressText
            // 
            this.CustomerAddressText.Location = new System.Drawing.Point(201, 55);
            this.CustomerAddressText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerAddressText.Name = "CustomerAddressText";
            this.CustomerAddressText.Size = new System.Drawing.Size(255, 20);
            this.CustomerAddressText.TabIndex = 8;
            this.CustomerAddressText.TextChanged += new System.EventHandler(this.CustomerAddressText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer Adress";
            // 
            // FeeText
            // 
            this.FeeText.Location = new System.Drawing.Point(201, 96);
            this.FeeText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FeeText.Name = "FeeText";
            this.FeeText.Size = new System.Drawing.Size(255, 20);
            this.FeeText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Performers";
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(317, 184);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(82, 37);
            this.NewButton.TabIndex = 13;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(403, 184);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(82, 37);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 280);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(82, 37);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ListOfPerformers
            // 
            this.ListOfPerformers.FormattingEnabled = true;
            this.ListOfPerformers.Location = new System.Drawing.Point(11, 184);
            this.ListOfPerformers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListOfPerformers.Name = "ListOfPerformers";
            this.ListOfPerformers.Size = new System.Drawing.Size(295, 21);
            this.ListOfPerformers.TabIndex = 17;
            this.ListOfPerformers.SelectedIndexChanged += new System.EventHandler(this.ListOfBureaus_SelectedIndexChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 327);
            this.Controls.Add(this.ListOfPerformers);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FeeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerAddressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServiceOfText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ServiceOfText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CustomerAddressText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FeeText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ComboBox ListOfPerformers;
	}
}