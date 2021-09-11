using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkDesafio
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void aLBUNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPostagens postagens = new FrmPostagens();
            postagens.ShowDialog();
        }

        private void tODOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlbuns albuns = new FrmAlbuns();
            albuns.ShowDialog();
        }

        private void tODOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTodos todos = new FrmTodos();
            todos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
