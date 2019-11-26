using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class frmCalculator : Form
    {
        public delegate void OperasiHitungEventHandler(int index, int a, int b);

        public event OperasiHitungEventHandler OnPerhitungan;

        public frmCalculator()
        {
            InitializeComponent();
            OpOperasi.Items.Add("Penjumlahan");
            OpOperasi.Items.Add("Pengurangan");
            OpOperasi.Items.Add("Perkalian");
            OpOperasi.Items.Add("Pembagian");
            OpOperasi.SelectedIndex = 0;
            OpOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if(OpOperasi.SelectedIndex == 0)
            {
                OnPerhitungan(0, NilaiA, NilaiB);
            }
            else if(OpOperasi.SelectedIndex == 1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if (OpOperasi.SelectedIndex == 2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
        }

        private void cbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
