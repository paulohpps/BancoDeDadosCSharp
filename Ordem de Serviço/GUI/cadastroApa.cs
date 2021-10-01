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
    public partial class cadastroApa : Form
    {
        public bool foimarcado;
        public string Marca;
        public string Serie;
        public string Modelo;
        public string Estado;
        public string Tipo;
        Conexao conect = new Conexao();
        public cadastroApa()
        {
            InitializeComponent();
        }
        
        private void cadastroApa_Load(object sender, EventArgs e)
        {

        }
        public string cadastroTipo()
        {
            if (TVButton.Checked)
            {
                Tipo = "TV";
            }
            else if (SomButton.Checked)
            {
                Tipo = "Som";
            }
            else if (DvdButton.Checked)
            {
                Tipo = "DVD";
            }
            else if (OutrosButton.Checked)
            {
                Tipo = "Outros";
            }
            return Tipo;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MarcaText.TextLength == 0 || ModeloText.TextLength == 0 || SerieText.TextLength == 0 || EstadoText.TextLength == 0)
            {
                MessageBox.Show("Todos os Campos devem estar preenchidos");
            }
            else
            {
                Marca = MarcaText.Text;
                Modelo = ModeloText.Text;
                Serie = SerieText.Text;
                Estado = EstadoText.Text;
                Tipo = cadastroTipo();
                string comando = "INSERT INTO Aparelhos(Marca, Modelo, NumeroDeSerie, Tipo, Estado) values(\'" + Marca + "\', \'" + Modelo + "\', \'" + Serie + "\', \'" + Tipo + "\',\'" + Estado + "\')";
                conect.aparelho(comando);
                cadastroTipo();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
