
namespace Flotta_Navale_JB
{
    partial class Ins_Comandante
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
            this.btn_AnnullaComandante = new System.Windows.Forms.Button();
            this.btn_CreaComandante = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tB_Telefono = new System.Windows.Forms.TextBox();
            this.tB_nomeComandante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP_Comandante = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_AnnullaComandante
            // 
            this.btn_AnnullaComandante.Location = new System.Drawing.Point(181, 183);
            this.btn_AnnullaComandante.Name = "btn_AnnullaComandante";
            this.btn_AnnullaComandante.Size = new System.Drawing.Size(75, 23);
            this.btn_AnnullaComandante.TabIndex = 23;
            this.btn_AnnullaComandante.Text = "Annulla";
            this.btn_AnnullaComandante.UseVisualStyleBackColor = true;
            this.btn_AnnullaComandante.Click += new System.EventHandler(this.btn_AnnullaComandante_Click);
            // 
            // btn_CreaComandante
            // 
            this.btn_CreaComandante.Location = new System.Drawing.Point(100, 183);
            this.btn_CreaComandante.Name = "btn_CreaComandante";
            this.btn_CreaComandante.Size = new System.Drawing.Size(75, 23);
            this.btn_CreaComandante.TabIndex = 22;
            this.btn_CreaComandante.Text = "Crea";
            this.btn_CreaComandante.UseVisualStyleBackColor = true;
            this.btn_CreaComandante.Click += new System.EventHandler(this.btn_CreaComandante_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data nascita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Stato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Servizio",
            "Pensione",
            "Licenziato"});
            this.comboBox1.Location = new System.Drawing.Point(128, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Servizio";
            // 
            // tB_Telefono
            // 
            this.tB_Telefono.Location = new System.Drawing.Point(128, 93);
            this.tB_Telefono.Name = "tB_Telefono";
            this.tB_Telefono.Size = new System.Drawing.Size(127, 20);
            this.tB_Telefono.TabIndex = 16;
            // 
            // tB_nomeComandante
            // 
            this.tB_nomeComandante.Location = new System.Drawing.Point(128, 66);
            this.tB_nomeComandante.Name = "tB_nomeComandante";
            this.tB_nomeComandante.Size = new System.Drawing.Size(127, 20);
            this.tB_nomeComandante.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "Comandante";
            // 
            // dTP_Comandante
            // 
            this.dTP_Comandante.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTP_Comandante.Location = new System.Drawing.Point(128, 120);
            this.dTP_Comandante.Name = "dTP_Comandante";
            this.dTP_Comandante.Size = new System.Drawing.Size(128, 20);
            this.dTP_Comandante.TabIndex = 24;
            // 
            // Ins_Comandante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 218);
            this.Controls.Add(this.dTP_Comandante);
            this.Controls.Add(this.btn_AnnullaComandante);
            this.Controls.Add(this.btn_CreaComandante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tB_Telefono);
            this.Controls.Add(this.tB_nomeComandante);
            this.Controls.Add(this.label1);
            this.Name = "Ins_Comandante";
            this.Text = "Inserimento comandante";
            this.Load += new System.EventHandler(this.Ins_Comandante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AnnullaComandante;
        private System.Windows.Forms.Button btn_CreaComandante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tB_Telefono;
        private System.Windows.Forms.TextBox tB_nomeComandante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP_Comandante;
    }
}