namespace FrameworkDesafio
{
    partial class FrmPostagens
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
            this.userid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.body = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_postagens
            // 
            this.lbl_postagens.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_postagens.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postagens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_postagens.Location = new System.Drawing.Point(1, 0);
            this.lbl_postagens.Name = "lbl_postagens";
            this.lbl_postagens.Size = new System.Drawing.Size(1370, 46);
            this.lbl_postagens.TabIndex = 7;
            this.lbl_postagens.Text = "POSTAGENS";
            this.lbl_postagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Location = new System.Drawing.Point(943, 529);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(179, 57);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_listar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_listar.Location = new System.Drawing.Point(205, 529);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(179, 57);
            this.btn_listar.TabIndex = 4;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userid,
            this.id,
            this.title,
            this.body});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(205, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(917, 311);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // userid
            // 
            this.userid.Text = "UserID";
            this.userid.Width = 48;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 30;
            // 
            // title
            // 
            this.title.Text = "TITLE";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 108;
            // 
            // body
            // 
            this.body.Text = "BODY";
            this.body.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.body.Width = 191;
            // 
            // FrmPostagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_postagens);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_listar);
            this.Name = "FrmPostagens";
            this.Text = "Postagens";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_postagens;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader userid;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader body;
    }
}