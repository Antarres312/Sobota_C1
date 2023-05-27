namespace GeneratorHasel
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
            this.cbx_numbers = new System.Windows.Forms.CheckBox();
            this.cbx_specials = new System.Windows.Forms.CheckBox();
            this.cbx_uppercase = new System.Windows.Forms.CheckBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.nud_length = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nud_length)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_numbers
            // 
            this.cbx_numbers.AutoSize = true;
            this.cbx_numbers.Checked = true;
            this.cbx_numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_numbers.Location = new System.Drawing.Point(21, 86);
            this.cbx_numbers.Name = "cbx_numbers";
            this.cbx_numbers.Size = new System.Drawing.Size(59, 20);
            this.cbx_numbers.TabIndex = 0;
            this.cbx_numbers.Text = "Cyfry";
            this.cbx_numbers.UseVisualStyleBackColor = true;
            // 
            // cbx_specials
            // 
            this.cbx_specials.AutoSize = true;
            this.cbx_specials.Checked = true;
            this.cbx_specials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_specials.Location = new System.Drawing.Point(21, 127);
            this.cbx_specials.Name = "cbx_specials";
            this.cbx_specials.Size = new System.Drawing.Size(124, 20);
            this.cbx_specials.TabIndex = 1;
            this.cbx_specials.Text = "Znaki specjalne";
            this.cbx_specials.UseVisualStyleBackColor = true;
            // 
            // cbx_uppercase
            // 
            this.cbx_uppercase.AutoSize = true;
            this.cbx_uppercase.Checked = true;
            this.cbx_uppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_uppercase.Location = new System.Drawing.Point(21, 166);
            this.cbx_uppercase.Name = "cbx_uppercase";
            this.cbx_uppercase.Size = new System.Drawing.Size(105, 20);
            this.cbx_uppercase.TabIndex = 2;
            this.cbx_uppercase.Text = "Wielkie litery";
            this.cbx_uppercase.UseVisualStyleBackColor = true;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(21, 217);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(266, 22);
            this.tbx_password.TabIndex = 3;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(21, 251);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(317, 42);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generuj";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // nud_length
            // 
            this.nud_length.Location = new System.Drawing.Point(199, 47);
            this.nud_length.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nud_length.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nud_length.Name = "nud_length";
            this.nud_length.Size = new System.Drawing.Size(79, 22);
            this.nud_length.TabIndex = 5;
            this.nud_length.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj długość hasła:";
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(293, 205);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(45, 40);
            this.btn_copy.TabIndex = 7;
            this.btn_copy.Text = "🔗";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(199, 299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(139, 34);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Zapisz...";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_length);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.cbx_uppercase);
            this.Controls.Add(this.cbx_specials);
            this.Controls.Add(this.cbx_numbers);
            this.Name = "Form1";
            this.Text = "Generator haseł";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbx_numbers;
        private System.Windows.Forms.CheckBox cbx_specials;
        private System.Windows.Forms.CheckBox cbx_uppercase;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.NumericUpDown nud_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

