namespace Szyfrowanie
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.Btn_process = new System.Windows.Forms.Button();
            this.rbt_szyfrowanie = new System.Windows.Forms.RadioButton();
            this.rbt_odszyfrowywanie = new System.Windows.Forms.RadioButton();
            this.NUD_przesuniecie = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_przesuniecie)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 12);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(248, 227);
            this.txt_input.TabIndex = 0;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(406, 12);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(248, 227);
            this.txt_output.TabIndex = 1;
            // 
            // Btn_process
            // 
            this.Btn_process.Location = new System.Drawing.Point(266, 183);
            this.Btn_process.Name = "Btn_process";
            this.Btn_process.Size = new System.Drawing.Size(134, 56);
            this.Btn_process.TabIndex = 2;
            this.Btn_process.Text = ">>>";
            this.Btn_process.UseVisualStyleBackColor = true;
            this.Btn_process.Click += new System.EventHandler(this.Btn_process_Click);
            // 
            // rbt_szyfrowanie
            // 
            this.rbt_szyfrowanie.AutoSize = true;
            this.rbt_szyfrowanie.Checked = true;
            this.rbt_szyfrowanie.Location = new System.Drawing.Point(266, 16);
            this.rbt_szyfrowanie.Name = "rbt_szyfrowanie";
            this.rbt_szyfrowanie.Size = new System.Drawing.Size(100, 20);
            this.rbt_szyfrowanie.TabIndex = 3;
            this.rbt_szyfrowanie.TabStop = true;
            this.rbt_szyfrowanie.Text = "Szyfrowanie";
            this.rbt_szyfrowanie.UseVisualStyleBackColor = true;
            // 
            // rbt_odszyfrowywanie
            // 
            this.rbt_odszyfrowywanie.AutoSize = true;
            this.rbt_odszyfrowywanie.Location = new System.Drawing.Point(268, 42);
            this.rbt_odszyfrowywanie.Name = "rbt_odszyfrowywanie";
            this.rbt_odszyfrowywanie.Size = new System.Drawing.Size(132, 20);
            this.rbt_odszyfrowywanie.TabIndex = 4;
            this.rbt_odszyfrowywanie.Text = "Odszyfrowywanie";
            this.rbt_odszyfrowywanie.UseVisualStyleBackColor = true;
            // 
            // NUD_przesuniecie
            // 
            this.NUD_przesuniecie.Location = new System.Drawing.Point(268, 87);
            this.NUD_przesuniecie.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUD_przesuniecie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_przesuniecie.Name = "NUD_przesuniecie";
            this.NUD_przesuniecie.Size = new System.Drawing.Size(63, 22);
            this.NUD_przesuniecie.TabIndex = 5;
            this.NUD_przesuniecie.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 268);
            this.Controls.Add(this.NUD_przesuniecie);
            this.Controls.Add(this.rbt_odszyfrowywanie);
            this.Controls.Add(this.rbt_szyfrowanie);
            this.Controls.Add(this.Btn_process);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.txt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_przesuniecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button Btn_process;
        private System.Windows.Forms.RadioButton rbt_szyfrowanie;
        private System.Windows.Forms.RadioButton rbt_odszyfrowywanie;
        private System.Windows.Forms.NumericUpDown NUD_przesuniecie;
    }
}

