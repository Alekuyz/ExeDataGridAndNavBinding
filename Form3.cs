﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exepabd
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRODIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.pRODIDataSet.mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa_Coba' table. You can move, or remove it, as needed.
            this.mahasiswa_CobaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa_Coba);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 before = new Form2();
            before.Show();
            this.Hide();
        }
    }
}