using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedido_De_Coleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pDCDataSet1.pdc'. Você pode movê-la ou removê-la conforme necessário.
            this.pdcTableAdapter1.Fill(this.pDCDataSet1.pdc);
            // TODO: esta linha de código carrega dados na tabela 'pDCDataSet.pdc'. Você pode movê-la ou removê-la conforme necessário.
            this.pdcTableAdapter.Fill(this.pDCDataSet.pdc);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Histórico histórico = new Histórico();
            histórico.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
