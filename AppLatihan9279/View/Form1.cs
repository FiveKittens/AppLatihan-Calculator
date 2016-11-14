using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLatihan9279.View
{
    public partial class Form1 : Form
    {
        private Interface.IntKalkulator calcDao;
        private Entity.EntKalkulator calc;

        public Form1()
        {
            calcDao = Factory.FactKalkulator.GetKalkulatorDao();
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            calc = new Entity.EntKalkulator();
            calc.setNilai1(double.Parse(txtNilai1.Text));
            calc.setNilai2(double.Parse(txtNilai2.Text));

            txtHasil.Text = calcDao.Penjumlahan(calc).ToString();
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            calc = new Entity.EntKalkulator();
            calc.setNilai1(double.Parse(txtNilai1.Text));
            calc.setNilai2(double.Parse(txtNilai2.Text));

            txtHasil.Text = calcDao.Perkalian(calc).ToString();
        }

        private void btnKurangi_Click(object sender, EventArgs e)
        {
            calc = new Entity.EntKalkulator();
            calc.setNilai1(double.Parse(txtNilai1.Text));
            calc.setNilai2(double.Parse(txtNilai2.Text));

            txtHasil.Text = calcDao.Pengurangan(calc).ToString();
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            calc = new Entity.EntKalkulator();
            calc.setNilai1(double.Parse(txtNilai1.Text));
            calc.setNilai2(double.Parse(txtNilai2.Text));

            txtHasil.Text = calcDao.Pembagian(calc).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNilai1.Clear();
            txtNilai2.Clear();
            txtHasil.Clear();
        }
    }
}
