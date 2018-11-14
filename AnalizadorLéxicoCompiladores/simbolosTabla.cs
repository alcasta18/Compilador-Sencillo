using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalizadorLéxicoCompiladores.Transversal;

namespace AnalizadorLéxicoCompiladores
{
    public partial class simbolosTabla : Form
    {
        public simbolosTabla()
        {
            InitializeComponent();
            dataGridView1.DataSource = TablaSimbolos.ObtenerInstancia().ObtenerTodo();
        }

        private void simbolosTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
