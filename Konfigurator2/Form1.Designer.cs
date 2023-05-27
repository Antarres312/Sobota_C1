namespace Konfigurator2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbt_Nowy = new System.Windows.Forms.ToolStripMenuItem();
            this.mbt_podsumowanie = new System.Windows.Forms.ToolStripMenuItem();
            this.mtx_nazwa = new System.Windows.Forms.ToolStripTextBox();
            this.btn_zatwierdz = new System.Windows.Forms.Button();
            this.btn_motyw = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(68, 178);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(103, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(68, 204);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbt_Nowy,
            this.mbt_podsumowanie,
            this.mtx_nazwa});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 31);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbt_Nowy
            // 
            this.mbt_Nowy.Name = "mbt_Nowy";
            this.mbt_Nowy.Size = new System.Drawing.Size(148, 27);
            this.mbt_Nowy.Text = "Nowa konfiguracja";
            // 
            // mbt_podsumowanie
            // 
            this.mbt_podsumowanie.Name = "mbt_podsumowanie";
            this.mbt_podsumowanie.Size = new System.Drawing.Size(123, 27);
            this.mbt_podsumowanie.Text = "Podsumowanie";
            // 
            // mtx_nazwa
            // 
            this.mtx_nazwa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mtx_nazwa.Name = "mtx_nazwa";
            this.mtx_nazwa.Size = new System.Drawing.Size(100, 27);
            this.mtx_nazwa.Text = "NowaKonfiguracja";
            // 
            // btn_zatwierdz
            // 
            this.btn_zatwierdz.Location = new System.Drawing.Point(68, 255);
            this.btn_zatwierdz.Name = "btn_zatwierdz";
            this.btn_zatwierdz.Size = new System.Drawing.Size(113, 50);
            this.btn_zatwierdz.TabIndex = 5;
            this.btn_zatwierdz.Text = "Zatwierdź";
            this.btn_zatwierdz.UseVisualStyleBackColor = true;
            // 
            // btn_motyw
            // 
            this.btn_motyw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_motyw.Location = new System.Drawing.Point(463, 34);
            this.btn_motyw.Name = "btn_motyw";
            this.btn_motyw.Size = new System.Drawing.Size(52, 48);
            this.btn_motyw.TabIndex = 6;
            this.btn_motyw.Text = "🌙";
            this.btn_motyw.UseVisualStyleBackColor = true;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(65, 68);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(116, 16);
            this.lbl_info.TabIndex = 7;
            this.lbl_info.Text = "Wybierz procesor:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 372);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 26);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_motyw);
            this.Controls.Add(this.btn_zatwierdz);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbt_Nowy;
        private System.Windows.Forms.ToolStripMenuItem mbt_podsumowanie;
        private System.Windows.Forms.ToolStripTextBox mtx_nazwa;
        private System.Windows.Forms.Button btn_zatwierdz;
        private System.Windows.Forms.Button btn_motyw;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

