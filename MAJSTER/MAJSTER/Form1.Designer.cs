namespace MAJSTER
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Dodaj = new System.Windows.Forms.Button();
			this.Produkty = new System.Windows.Forms.ListBox();
			this.Zamówienie = new System.Windows.Forms.ListBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.Opis = new System.Windows.Forms.ListBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(28, 374);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(59, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "faktura";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(335, 370);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Zamów";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Dodaj
			// 
			this.Dodaj.Location = new System.Drawing.Point(335, 252);
			this.Dodaj.Name = "Dodaj";
			this.Dodaj.Size = new System.Drawing.Size(75, 23);
			this.Dodaj.TabIndex = 2;
			this.Dodaj.Text = "Dodaj";
			this.Dodaj.UseVisualStyleBackColor = true;
			this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
			// 
			// Produkty
			// 
			this.Produkty.FormattingEnabled = true;
			this.Produkty.Location = new System.Drawing.Point(28, 47);
			this.Produkty.Name = "Produkty";
			this.Produkty.Size = new System.Drawing.Size(382, 199);
			this.Produkty.TabIndex = 3;
			this.Produkty.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Zamówienie
			// 
			this.Zamówienie.FormattingEnabled = true;
			this.Zamówienie.Location = new System.Drawing.Point(28, 295);
			this.Zamówienie.Name = "Zamówienie";
			this.Zamówienie.Size = new System.Drawing.Size(382, 69);
			this.Zamówienie.TabIndex = 4;
			this.Zamówienie.SelectedIndexChanged += new System.EventHandler(this.ZAMOWIENIE_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(434, 47);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(174, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.Text = "Kategoria";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Opis
			// 
			this.Opis.FormattingEnabled = true;
			this.Opis.Location = new System.Drawing.Point(434, 99);
			this.Opis.Name = "Opis";
			this.Opis.Size = new System.Drawing.Size(174, 147);
			this.Opis.TabIndex = 6;
			this.Opis.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(471, 295);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(105, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(639, 439);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Opis);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Zamówienie);
			this.Controls.Add(this.Produkty);
			this.Controls.Add(this.Dodaj);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Name = "Form1";
			this.Text = "Majasterklepka";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Dodaj;
		private System.Windows.Forms.ListBox Produkty;
		private System.Windows.Forms.ListBox Zamówienie;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ListBox Opis;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

