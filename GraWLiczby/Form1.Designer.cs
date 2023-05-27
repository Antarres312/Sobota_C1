namespace GraWLiczby
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_rownanie = new System.Windows.Forms.Label();
            this.txt_wynik = new System.Windows.Forms.TextBox();
            this.btn_sprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wynik równania:";
            // 
            // lbl_rownanie
            // 
            this.lbl_rownanie.AutoSize = true;
            this.lbl_rownanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rownanie.Location = new System.Drawing.Point(12, 99);
            this.lbl_rownanie.Name = "lbl_rownanie";
            this.lbl_rownanie.Size = new System.Drawing.Size(111, 29);
            this.lbl_rownanie.TabIndex = 1;
            this.lbl_rownanie.Text = "11 + 11 =";
            // 
            // txt_wynik
            // 
            this.txt_wynik.Location = new System.Drawing.Point(17, 150);
            this.txt_wynik.Name = "txt_wynik";
            this.txt_wynik.Size = new System.Drawing.Size(100, 22);
            this.txt_wynik.TabIndex = 2;
            // 
            // btn_sprawdz
            // 
            this.btn_sprawdz.Location = new System.Drawing.Point(17, 202);
            this.btn_sprawdz.Name = "btn_sprawdz";
            this.btn_sprawdz.Size = new System.Drawing.Size(134, 23);
            this.btn_sprawdz.TabIndex = 3;
            this.btn_sprawdz.Text = "Sprawdź";
            this.btn_sprawdz.UseVisualStyleBackColor = true;
            this.btn_sprawdz.Click += new System.EventHandler(this.btn_sprawdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 365);
            this.Controls.Add(this.btn_sprawdz);
            this.Controls.Add(this.txt_wynik);
            this.Controls.Add(this.lbl_rownanie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_rownanie;
        private System.Windows.Forms.TextBox txt_wynik;
        private System.Windows.Forms.Button btn_sprawdz;
    }
}

