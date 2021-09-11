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
    public partial class FrmAlbuns : Form
    {
        public FrmAlbuns()
        {
            InitializeComponent();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            var album = Albuns.ListarAlbum();

            foreach (Albuns a in album)
            {
                ListViewItem item = new ListViewItem(new[] { a.userId.ToString(), a.id.ToString(), a.title });
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
