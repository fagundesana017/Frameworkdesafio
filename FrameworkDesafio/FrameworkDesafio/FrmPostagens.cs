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
    public partial class FrmPostagens : Form
    {
        public FrmPostagens()
        {
            InitializeComponent();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            var post = Postagens.ListarPostagens();

            foreach (Postagens m in post)
            {
                ListViewItem item = new ListViewItem(new[] { m.userId.ToString(), m.id.ToString(), m.title, m.body});
                listView1.Items.Add(item);
            }

           
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }
    }
}
