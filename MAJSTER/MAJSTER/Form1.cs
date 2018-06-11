using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MAJSTER
{
	public partial class Form1 : Form
	{
		Db db;
		public Form1()
		{
			InitializeComponent();
			db = new Db();

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void ZAMOWIENIE_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Dodaj_Click(object sender, EventArgs e)
		{

			Produkty.Items.AddRange(db.KL("300"));
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Kategorie
		}
	}
}
