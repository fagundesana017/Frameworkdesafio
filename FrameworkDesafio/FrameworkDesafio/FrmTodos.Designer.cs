namespace FrameworkDesafio
{
    partial class FrmTodos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_postagens = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Userid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.completed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_postagens
            // 
            this.lbl_postagens.BackColor = System.Drawing.Color.MediumOrchid;
            this.lbl_postagens.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postagens.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_postagens.Location = new System.Drawing.Point(0, 0);
            this.lbl_postagens.Name = "lbl_postagens";
            this.lbl_postagens.Size = new System.Drawing.Size(1372, 46);
            this.lbl_postagens.TabIndex = 11;
            this.lbl_postagens.Text = "TODOS";
            this.lbl_postagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Plum;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_voltar.Location = new System.Drawing.Point(1060, 590);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(153, 60);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.BackColor = System.Drawing.Color.Plum;
            this.btn_listar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_listar.Location = new System.Drawing.Point(148, 590);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(153, 60);
            this.btn_listar.TabIndex = 8;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Userid,
            this.id,
            this.title,
            this.completed});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(148, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1065, 386);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Userid
            // 
            this.Userid.Text = "UserID";
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title
            // 
            this.title.Text = "TITLE";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 211;
            // 
            // completed
            // 
            this.completed.Text = "COMPLETED";
            this.completed.Width = 114;
            // 
            // FrmTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_postagens);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_listar);
            this.Name = "FrmTodos";
            this.Text = "FrmTodos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_postagens;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Userid;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader completed;
    }
}