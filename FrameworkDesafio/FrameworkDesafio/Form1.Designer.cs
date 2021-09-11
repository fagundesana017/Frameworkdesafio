namespace FrameworkDesafio
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSTAGENSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLBUNSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tODOSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Indigo;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSTAGENSToolStripMenuItem,
            this.aLBUNSToolStripMenuItem,
            this.tODOSToolStripMenuItem,
            this.tODOSToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSTAGENSToolStripMenuItem
            // 
            this.pOSTAGENSToolStripMenuItem.Checked = true;
            this.pOSTAGENSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pOSTAGENSToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOSTAGENSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pOSTAGENSToolStripMenuItem.Name = "pOSTAGENSToolStripMenuItem";
            this.pOSTAGENSToolStripMenuItem.Size = new System.Drawing.Size(97, 46);
            this.pOSTAGENSToolStripMenuItem.Text = "FRAMEWORK";
            // 
            // aLBUNSToolStripMenuItem
            // 
            this.aLBUNSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aLBUNSToolStripMenuItem.Name = "aLBUNSToolStripMenuItem";
            this.aLBUNSToolStripMenuItem.Size = new System.Drawing.Size(83, 46);
            this.aLBUNSToolStripMenuItem.Text = "POSTAGENS";
            this.aLBUNSToolStripMenuItem.Click += new System.EventHandler(this.aLBUNSToolStripMenuItem_Click);
            // 
            // tODOSToolStripMenuItem
            // 
            this.tODOSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tODOSToolStripMenuItem.Name = "tODOSToolStripMenuItem";
            this.tODOSToolStripMenuItem.Size = new System.Drawing.Size(63, 46);
            this.tODOSToolStripMenuItem.Text = "ALBUNS";
            this.tODOSToolStripMenuItem.Click += new System.EventHandler(this.tODOSToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tODOSToolStripMenuItem1
            // 
            this.tODOSToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tODOSToolStripMenuItem1.Name = "tODOSToolStripMenuItem1";
            this.tODOSToolStripMenuItem1.Size = new System.Drawing.Size(56, 46);
            this.tODOSToolStripMenuItem1.Text = "TODOS";
            this.tODOSToolStripMenuItem1.Click += new System.EventHandler(this.tODOSToolStripMenuItem1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::FrameworkDesafio.Properties.Resources.p;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(699, 409);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(671, 365);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::FrameworkDesafio.Properties.Resources.i;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 342);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FrameworkDesafio.Properties.Resources.framework;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 389);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(25, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSTAGENSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLBUNSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tODOSToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tODOSToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

