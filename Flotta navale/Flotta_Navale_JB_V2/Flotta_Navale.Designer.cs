
namespace Flotta_Navale_JB
{
    partial class FlottaNavale
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
            this.dGV_Navi = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stazza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velocità = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_Comandanti = new System.Windows.Forms.DataGridView();
            this.NomeComandante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datadinascita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statocomandante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comandanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.l_Flotta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Navi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Comandanti)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Navi
            // 
            this.dGV_Navi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Navi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Stazza,
            this.Velocità,
            this.Stato});
            this.dGV_Navi.Location = new System.Drawing.Point(12, 96);
            this.dGV_Navi.Name = "dGV_Navi";
            this.dGV_Navi.Size = new System.Drawing.Size(450, 200);
            this.dGV_Navi.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Stazza
            // 
            this.Stazza.HeaderText = "Stazza";
            this.Stazza.Name = "Stazza";
            // 
            // Velocità
            // 
            this.Velocità.HeaderText = "Velocità";
            this.Velocità.Name = "Velocità";
            // 
            // Stato
            // 
            this.Stato.HeaderText = "Stato";
            this.Stato.Name = "Stato";
            // 
            // dGV_Comandanti
            // 
            this.dGV_Comandanti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Comandanti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeComandante,
            this.Telefono,
            this.Datadinascita,
            this.Statocomandante});
            this.dGV_Comandanti.Location = new System.Drawing.Point(468, 96);
            this.dGV_Comandanti.Name = "dGV_Comandanti";
            this.dGV_Comandanti.Size = new System.Drawing.Size(450, 200);
            this.dGV_Comandanti.TabIndex = 1;
            // 
            // NomeComandante
            // 
            this.NomeComandante.HeaderText = "Nome";
            this.NomeComandante.Name = "NomeComandante";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Datadinascita
            // 
            this.Datadinascita.HeaderText = "Data di nascita";
            this.Datadinascita.Name = "Datadinascita";
            // 
            // Statocomandante
            // 
            this.Statocomandante.HeaderText = "Stato";
            this.Statocomandante.Name = "Statocomandante";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.naveToolStripMenuItem,
            this.comandanteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // naveToolStripMenuItem
            // 
            this.naveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem1,
            this.modificaToolStripMenuItem1,
            this.cancellaToolStripMenuItem1});
            this.naveToolStripMenuItem.Name = "naveToolStripMenuItem";
            this.naveToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.naveToolStripMenuItem.Text = "Nave";
            // 
            // creaToolStripMenuItem1
            // 
            this.creaToolStripMenuItem1.Name = "creaToolStripMenuItem1";
            this.creaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.creaToolStripMenuItem1.Text = "Crea";
            this.creaToolStripMenuItem1.Click += new System.EventHandler(this.creaToolStripMenuItem1_Click);
            // 
            // modificaToolStripMenuItem1
            // 
            this.modificaToolStripMenuItem1.Name = "modificaToolStripMenuItem1";
            this.modificaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem1.Text = "Modifica";
            // 
            // cancellaToolStripMenuItem1
            // 
            this.cancellaToolStripMenuItem1.Name = "cancellaToolStripMenuItem1";
            this.cancellaToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.cancellaToolStripMenuItem1.Text = "Cancella";
            // 
            // comandanteToolStripMenuItem
            // 
            this.comandanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.cancellaToolStripMenuItem});
            this.comandanteToolStripMenuItem.Name = "comandanteToolStripMenuItem";
            this.comandanteToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.comandanteToolStripMenuItem.Text = "Comandante";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creaToolStripMenuItem.Text = "Crea";
            this.creaToolStripMenuItem.Click += new System.EventHandler(this.creaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // cancellaToolStripMenuItem
            // 
            this.cancellaToolStripMenuItem.Name = "cancellaToolStripMenuItem";
            this.cancellaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancellaToolStripMenuItem.Text = "Cancella";
            // 
            // l_Flotta
            // 
            this.l_Flotta.AllowDrop = true;
            this.l_Flotta.AutoSize = true;
            this.l_Flotta.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.l_Flotta.Location = new System.Drawing.Point(375, 24);
            this.l_Flotta.Name = "l_Flotta";
            this.l_Flotta.Size = new System.Drawing.Size(102, 36);
            this.l_Flotta.TabIndex = 3;
            this.l_Flotta.Text = "Flotta:";
            this.l_Flotta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista Navi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(464, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista Comandanti:";
            // 
            // FlottaNavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_Flotta);
            this.Controls.Add(this.dGV_Comandanti);
            this.Controls.Add(this.dGV_Navi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlottaNavale";
            this.Text = "Flotta navale";
            this.Load += new System.EventHandler(this.FlottaNavale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Navi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Comandanti)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Navi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stazza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velocità;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stato;
        private System.Windows.Forms.DataGridView dGV_Comandanti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comandanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem;
        private System.Windows.Forms.Label l_Flotta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeComandante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datadinascita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statocomandante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

