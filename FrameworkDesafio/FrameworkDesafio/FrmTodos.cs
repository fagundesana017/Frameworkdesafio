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
    public partial class FrmTodos : Form
    {
        public FrmTodos()
        {
            InitializeComponent();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {

            var todos = Todos.ListarTodos();

            foreach (Todos t in todos)
            {
                ListViewItem item = new ListViewItem(new[] { t.userId.ToString(), t.id.ToString(), t.title, t.completed.ToString() });
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
