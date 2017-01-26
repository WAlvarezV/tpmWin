namespace MercaClick
{
    partial class frmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.pmiInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.smiGestiónProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmiInventario});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(922, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // pmiInventario
            // 
            this.pmiInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiGestiónProductos});
            this.pmiInventario.Name = "pmiInventario";
            this.pmiInventario.Size = new System.Drawing.Size(105, 24);
            this.pmiInventario.Text = "INVENTARIO";
            // 
            // smiGestiónProductos
            // 
            this.smiGestiónProductos.Name = "smiGestiónProductos";
            this.smiGestiónProductos.Size = new System.Drawing.Size(204, 26);
            this.smiGestiónProductos.Text = "Gestión Productos";
            this.smiGestiónProductos.Click += new System.EventHandler(this.smiGestiónProductos_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Location = new System.Drawing.Point(0, 412);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(922, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 434);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem pmiInventario;
        private System.Windows.Forms.ToolStripMenuItem smiGestiónProductos;
        private System.Windows.Forms.StatusStrip statusBar;
    }
}