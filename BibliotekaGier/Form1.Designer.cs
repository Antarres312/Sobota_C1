namespace BibliotekaGier
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_tytuly = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Opis = new System.Windows.Forms.TextBox();
            this.lbl_Tytul = new System.Windows.Forms.Label();
            this.scoreBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_tytuly
            // 
            this.lbx_tytuly.FormattingEnabled = true;
            this.lbx_tytuly.ItemHeight = 16;
            this.lbx_tytuly.Location = new System.Drawing.Point(12, 12);
            this.lbx_tytuly.Name = "lbx_tytuly";
            this.lbx_tytuly.Size = new System.Drawing.Size(273, 308);
            this.lbx_tytuly.TabIndex = 0;
            this.lbx_tytuly.SelectedIndexChanged += new System.EventHandler(this.lbx_tytuly_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scoreBar);
            this.groupBox1.Controls.Add(this.txt_Opis);
            this.groupBox1.Controls.Add(this.lbl_Tytul);
            this.groupBox1.Location = new System.Drawing.Point(291, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje";
            // 
            // txt_Opis
            // 
            this.txt_Opis.Enabled = false;
            this.txt_Opis.Location = new System.Drawing.Point(18, 62);
            this.txt_Opis.Multiline = true;
            this.txt_Opis.Name = "txt_Opis";
            this.txt_Opis.Size = new System.Drawing.Size(358, 98);
            this.txt_Opis.TabIndex = 1;
            // 
            // lbl_Tytul
            // 
            this.lbl_Tytul.AutoSize = true;
            this.lbl_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tytul.Location = new System.Drawing.Point(13, 27);
            this.lbl_Tytul.Name = "lbl_Tytul";
            this.lbl_Tytul.Size = new System.Drawing.Size(60, 24);
            this.lbl_Tytul.TabIndex = 0;
            this.lbl_Tytul.Text = "label1";
            // 
            // scoreBar
            // 
            this.scoreBar.Location = new System.Drawing.Point(17, 166);
            this.scoreBar.Name = "scoreBar";
            this.scoreBar.Size = new System.Drawing.Size(359, 45);
            this.scoreBar.Step = 1;
            this.scoreBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbx_tytuly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_tytuly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Opis;
        private System.Windows.Forms.Label lbl_Tytul;
        private System.Windows.Forms.ProgressBar scoreBar;
    }
}

