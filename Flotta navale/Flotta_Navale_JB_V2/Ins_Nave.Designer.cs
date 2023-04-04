
namespace Flotta_Navale_JB
{
    partial class Ins_Nave
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_nomeNave = new System.Windows.Forms.TextBox();
            this.tB_velocitaNave = new System.Windows.Forms.TextBox();
            this.tB_stazzaNave = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CreaNave = new System.Windows.Forms.Button();
            this.btn_AnnullaNave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nave";
            // 
            // tB_nomeNave
            // 
            this.tB_nomeNave.Location = new System.Drawing.Point(95, 66);
            this.tB_nomeNave.Name = "tB_nomeNave";
            this.tB_nomeNave.Size = new System.Drawing.Size(127, 20);
            this.tB_nomeNave.TabIndex = 2;
            // 
            // tB_velocitaNave
            // 
            this.tB_velocitaNave.Location = new System.Drawing.Point(95, 121);
            this.tB_velocitaNave.Name = "tB_velocitaNave";
            this.tB_velocitaNave.Size = new System.Drawing.Size(127, 20);
            this.tB_velocitaNave.TabIndex = 3;
            // 
            // tB_stazzaNave
            // 
            this.tB_stazzaNave.Location = new System.Drawing.Point(95, 93);
            this.tB_stazzaNave.Name = "tB_stazzaNave";
            this.tB_stazzaNave.Size = new System.Drawing.Size(127, 20);
            this.tB_stazzaNave.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cantiere",
            "Varata",
            "Demolita"});
            this.comboBox1.Location = new System.Drawing.Point(95, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Cantiere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Velocità";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stazza";
            // 
            // btn_CreaNave
            // 
            this.btn_CreaNave.Location = new System.Drawing.Point(66, 186);
            this.btn_CreaNave.Name = "btn_CreaNave";
            this.btn_CreaNave.Size = new System.Drawing.Size(75, 23);
            this.btn_CreaNave.TabIndex = 11;
            this.btn_CreaNave.Text = "Crea";
            this.btn_CreaNave.UseVisualStyleBackColor = true;
            this.btn_CreaNave.Click += new System.EventHandler(this.btn_CreaNave_Click);
            // 
            // btn_AnnullaNave
            // 
            this.btn_AnnullaNave.Location = new System.Drawing.Point(147, 186);
            this.btn_AnnullaNave.Name = "btn_AnnullaNave";
            this.btn_AnnullaNave.Size = new System.Drawing.Size(75, 23);
            this.btn_AnnullaNave.TabIndex = 12;
            this.btn_AnnullaNave.Text = "Annulla";
            this.btn_AnnullaNave.UseVisualStyleBackColor = true;
            this.btn_AnnullaNave.Click += new System.EventHandler(this.btn_AnnullaNave_Click);
            // 
            // Ins_Nave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 218);
            this.Controls.Add(this.btn_AnnullaNave);
            this.Controls.Add(this.btn_CreaNave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tB_stazzaNave);
            this.Controls.Add(this.tB_velocitaNave);
            this.Controls.Add(this.tB_nomeNave);
            this.Controls.Add(this.label1);
            this.Name = "Ins_Nave";
            this.Text = "Inserimento nave";
            this.Load += new System.EventHandler(this.Ins_Nave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_nomeNave;
        private System.Windows.Forms.TextBox tB_velocitaNave;
        private System.Windows.Forms.TextBox tB_stazzaNave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CreaNave;
        private System.Windows.Forms.Button btn_AnnullaNave;
    }
}