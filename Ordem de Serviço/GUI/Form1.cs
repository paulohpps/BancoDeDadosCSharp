﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordem_de_Serviço
{
    public partial class Form1 : Form
    {
        Form2 cad = new Form2();
        ConsultarClientes clientesconsula = new ConsultarClientes();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 cad = new Form2();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientesconsula = new ConsultarClientes();
            clientesconsula.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
