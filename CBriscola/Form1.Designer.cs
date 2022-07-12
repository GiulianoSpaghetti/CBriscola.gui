namespace CBriscola
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.controllaAggiornamentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.coloriToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaPartitaToolStripMenuItem,
            this.opzioniToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nuovaPartitaToolStripMenuItem
            // 
            this.nuovaPartitaToolStripMenuItem.Name = "nuovaPartitaToolStripMenuItem";
            this.nuovaPartitaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.nuovaPartitaToolStripMenuItem.Text = "Nuova Partita";
            // 
            // opzioniToolStripMenuItem
            // 
            this.opzioniToolStripMenuItem.Name = "opzioniToolStripMenuItem";
            this.opzioniToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.opzioniToolStripMenuItem.Text = "Opzioni";
            this.opzioniToolStripMenuItem.Click += new System.EventHandler(this.opzioniToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // coloriToolStripMenuItem
            // 
            this.coloriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testoToolStripMenuItem,
            this.sfondoToolStripMenuItem});
            this.coloriToolStripMenuItem.Name = "coloriToolStripMenuItem";
            this.coloriToolStripMenuItem.Size = new System.Drawing.Size(98, 38);
            this.coloriToolStripMenuItem.Text = "Colori";
            // 
            // testoToolStripMenuItem
            // 
            this.testoToolStripMenuItem.Name = "testoToolStripMenuItem";
            this.testoToolStripMenuItem.Size = new System.Drawing.Size(226, 44);
            this.testoToolStripMenuItem.Text = "Testo";
            this.testoToolStripMenuItem.Click += new System.EventHandler(this.testoToolStripMenuItem_Click);
            // 
            // sfondoToolStripMenuItem
            // 
            this.sfondoToolStripMenuItem.Name = "sfondoToolStripMenuItem";
            this.sfondoToolStripMenuItem.Size = new System.Drawing.Size(226, 44);
            this.sfondoToolStripMenuItem.Text = "Sfondo";
            this.sfondoToolStripMenuItem.Click += new System.EventHandler(this.sfondoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controllaAggiornamentiToolStripMenuItem,
            this.informazioniToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 38);
            this.toolStripMenuItem1.Text = "?";
            // 
            // controllaAggiornamentiToolStripMenuItem
            // 
            this.controllaAggiornamentiToolStripMenuItem.Name = "controllaAggiornamentiToolStripMenuItem";
            this.controllaAggiornamentiToolStripMenuItem.Size = new System.Drawing.Size(412, 44);
            this.controllaAggiornamentiToolStripMenuItem.Text = "Controlla Aggiornamenti";
            // 
            // informazioniToolStripMenuItem
            // 
            this.informazioniToolStripMenuItem.Name = "informazioniToolStripMenuItem";
            this.informazioniToolStripMenuItem.Size = new System.Drawing.Size(412, 44);
            this.informazioniToolStripMenuItem.Text = "Informazioni";
            this.informazioniToolStripMenuItem.Click += new System.EventHandler(this.informazioniToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 823);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CBriscola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaPartitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sfondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controllaAggiornamentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniToolStripMenuItem;
    }
}

