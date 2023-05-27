namespace KalkulatorOcen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_polski = new System.Windows.Forms.TextBox();
            this.txt_biologia = new System.Windows.Forms.TextBox();
            this.txt_geografia = new System.Windows.Forms.TextBox();
            this.txt_angielski = new System.Windows.Forms.TextBox();
            this.txt_matematyka = new System.Windows.Forms.TextBox();
            this.btn_median = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocena z matematyki";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ocena z polskiego";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocena z angielskiego";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocena biologii";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(26, 297);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(57, 16);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "Średnia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ocena z geografii";
            // 
            // txt_polski
            // 
            this.txt_polski.Location = new System.Drawing.Point(181, 92);
            this.txt_polski.Name = "txt_polski";
            this.txt_polski.Size = new System.Drawing.Size(100, 22);
            this.txt_polski.TabIndex = 6;
            // 
            // txt_biologia
            // 
            this.txt_biologia.Location = new System.Drawing.Point(181, 172);
            this.txt_biologia.Name = "txt_biologia";
            this.txt_biologia.Size = new System.Drawing.Size(100, 22);
            this.txt_biologia.TabIndex = 7;
            // 
            // txt_geografia
            // 
            this.txt_geografia.Location = new System.Drawing.Point(181, 220);
            this.txt_geografia.Name = "txt_geografia";
            this.txt_geografia.Size = new System.Drawing.Size(100, 22);
            this.txt_geografia.TabIndex = 8;
            // 
            // txt_angielski
            // 
            this.txt_angielski.Location = new System.Drawing.Point(181, 133);
            this.txt_angielski.Name = "txt_angielski";
            this.txt_angielski.Size = new System.Drawing.Size(100, 22);
            this.txt_angielski.TabIndex = 9;
            // 
            // txt_matematyka
            // 
            this.txt_matematyka.Location = new System.Drawing.Point(181, 55);
            this.txt_matematyka.Name = "txt_matematyka";
            this.txt_matematyka.Size = new System.Drawing.Size(100, 22);
            this.txt_matematyka.TabIndex = 10;
            // 
            // btn_median
            // 
            this.btn_median.Location = new System.Drawing.Point(181, 248);
            this.btn_median.Name = "btn_median";
            this.btn_median.Size = new System.Drawing.Size(100, 27);
            this.btn_median.TabIndex = 11;
            this.btn_median.Text = "Oblicz";
            this.btn_median.UseVisualStyleBackColor = true;
            this.btn_median.Click += new System.EventHandler(this.btn_median_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Wprowadź oceny końcowe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 331);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_median);
            this.Controls.Add(this.txt_matematyka);
            this.Controls.Add(this.txt_angielski);
            this.Controls.Add(this.txt_geografia);
            this.Controls.Add(this.txt_biologia);
            this.Controls.Add(this.txt_polski);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_polski;
        private System.Windows.Forms.TextBox txt_biologia;
        private System.Windows.Forms.TextBox txt_geografia;
        private System.Windows.Forms.TextBox txt_angielski;
        private System.Windows.Forms.TextBox txt_matematyka;
        private System.Windows.Forms.Button btn_median;
        private System.Windows.Forms.Label label7;
    }
}

