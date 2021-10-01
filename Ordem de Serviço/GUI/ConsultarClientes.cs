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
    public partial class ConsultarClientes : Form
    {
        Conexao connect = new Conexao();
        string comando = "usuario";
        public ConsultarClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = connect.Consultar(comando);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
