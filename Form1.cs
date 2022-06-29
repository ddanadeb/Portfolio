using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjekatRezervacije
{
    public partial class Form1 : Form
    {
        SqlConnection konekcija = new SqlConnection(Konekcija.konstring);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tableRezTableAdapter1.Fill(this.hotelDataSet1.TableRez);
            ukupnoRezervacija();
        }

        private void ukupnoRezervacija()
        {
            int broj = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 2; i++)
            {
                if(!String.IsNullOrEmpty(dataGridView1[3,i].Value.ToString()))
                {
                    broj++;
                }
            }
            tbUkupno.Text = broj.ToString();
        }
    }
}
