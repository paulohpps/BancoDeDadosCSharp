using System;
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
    public partial class Form2 : Form
    {
        public bool aparelho = false;
        Conexao conect = new Conexao();
        cadastroApa cadAP = new cadastroApa();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void CadastraApenaCli()
        {
            if (NomeText.TextLength == 0 || EndText.TextLength == 0 || TelText.TextLength == 0)
            {
                MessageBox.Show("Todos os Campos devem estar preenchidos");
            }
            else
            {
                Conexao conect = new Conexao();
                string comando = "INSERT INTO Clientes(Nome, telefone, endereco) values(\'" + NomeText.Text.ToString() + "\', \'" + TelText.Text.ToString() + "\', \'" + EndText.Text.ToString() + "\')";
                conect.Main(comando);
                NomeText.Text = "";
                TelText.Text = "";
                EndText.Text = "";
                MessageBox.Show("Cliente e Aparelho Cadastrado Com Sucesso");
            }

            
        }
        public void CadastraCliente()
        {
            if (NomeText.TextLength == 0 || EndText.TextLength == 0 || TelText.TextLength == 0)
            {
                MessageBox.Show("Todos os Campos devem estar preenchidos");
            }
            else
            {
                Conexao conect = new Conexao();
                string comando = "INSERT INTO Clientes(Nome, telefone, endereco) values(\'" + NomeText.Text.ToString() + "\', \'" + TelText.Text.ToString() + "\', \'" + EndText.Text.ToString() + "\')";
                conect.Main(comando);
                NomeText.Text = "";
                TelText.Text = "";
                EndText.Text = "";
                MessageBox.Show("Cliente Cadastrado Com Sucesso");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(aparelho == false)
            {
                CadastraCliente();
            }
            else if(aparelho == true)
            {
                CadastraApenaCli();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastroApa cadAP = new cadastroApa();
            cadAP.Show();
            aparelho = true;
        }
    }
}
