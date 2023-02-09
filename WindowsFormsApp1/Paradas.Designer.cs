namespace WindowsFormsApp1
{
    partial class Paradas
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
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.total_parada2 = new System.Windows.Forms.TextBox();
            this.total_parada1 = new System.Windows.Forms.TextBox();
            this.cb_paradafin1 = new System.Windows.Forms.ComboBox();
            this.cb_paradafin2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_parada2 = new System.Windows.Forms.ComboBox();
            this.cb_parada1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tex_paradas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nueva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "OBSERVACIONES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 54;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "TIPO_PARADAS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // total_parada2
            // 
            this.total_parada2.Location = new System.Drawing.Point(114, 92);
            this.total_parada2.Name = "total_parada2";
            this.total_parada2.Size = new System.Drawing.Size(70, 20);
            this.total_parada2.TabIndex = 51;
            this.total_parada2.TextChanged += new System.EventHandler(this.total_parada2_TextChanged);
            // 
            // total_parada1
            // 
            this.total_parada1.Location = new System.Drawing.Point(30, 92);
            this.total_parada1.Name = "total_parada1";
            this.total_parada1.Size = new System.Drawing.Size(70, 20);
            this.total_parada1.TabIndex = 50;
            this.total_parada1.TextChanged += new System.EventHandler(this.total_parada1_TextChanged);
            // 
            // cb_paradafin1
            // 
            this.cb_paradafin1.FormattingEnabled = true;
            this.cb_paradafin1.Location = new System.Drawing.Point(30, 65);
            this.cb_paradafin1.Name = "cb_paradafin1";
            this.cb_paradafin1.Size = new System.Drawing.Size(70, 21);
            this.cb_paradafin1.TabIndex = 49;
            this.cb_paradafin1.SelectedIndexChanged += new System.EventHandler(this.cb_paradafin1_SelectedIndexChanged);
            // 
            // cb_paradafin2
            // 
            this.cb_paradafin2.FormattingEnabled = true;
            this.cb_paradafin2.Location = new System.Drawing.Point(114, 65);
            this.cb_paradafin2.Name = "cb_paradafin2";
            this.cb_paradafin2.Size = new System.Drawing.Size(70, 21);
            this.cb_paradafin2.TabIndex = 48;
            this.cb_paradafin2.SelectedIndexChanged += new System.EventHandler(this.cb_paradafin2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "T 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "T 1";
            // 
            // cb_parada2
            // 
            this.cb_parada2.FormattingEnabled = true;
            this.cb_parada2.Location = new System.Drawing.Point(114, 38);
            this.cb_parada2.Name = "cb_parada2";
            this.cb_parada2.Size = new System.Drawing.Size(70, 21);
            this.cb_parada2.TabIndex = 45;
            this.cb_parada2.SelectedIndexChanged += new System.EventHandler(this.cb_parada2_SelectedIndexChanged);
            // 
            // cb_parada1
            // 
            this.cb_parada1.FormattingEnabled = true;
            this.cb_parada1.Location = new System.Drawing.Point(30, 38);
            this.cb_parada1.Name = "cb_parada1";
            this.cb_parada1.Size = new System.Drawing.Size(70, 21);
            this.cb_parada1.TabIndex = 44;
            this.cb_parada1.SelectedIndexChanged += new System.EventHandler(this.cb_parada1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "PARADAS";
            // 
            // tex_paradas
            // 
            this.tex_paradas.Location = new System.Drawing.Point(339, 38);
            this.tex_paradas.Name = "tex_paradas";
            this.tex_paradas.Size = new System.Drawing.Size(70, 20);
            this.tex_paradas.TabIndex = 56;
            this.tex_paradas.TextChanged += new System.EventHandler(this.paradas_acumuladas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Paradas_Acu";
            // 
            // nueva
            // 
            this.nueva.Location = new System.Drawing.Point(260, 65);
            this.nueva.Name = "nueva";
            this.nueva.Size = new System.Drawing.Size(73, 23);
            this.nueva.TabIndex = 58;
            this.nueva.Text = "NUEVA";
            this.nueva.UseVisualStyleBackColor = true;
            this.nueva.Click += new System.EventHandler(this.nueva_Click);
            // 
            // Paradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.nueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tex_paradas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.total_parada2);
            this.Controls.Add(this.total_parada1);
            this.Controls.Add(this.cb_paradafin1);
            this.Controls.Add(this.cb_paradafin2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_parada2);
            this.Controls.Add(this.cb_parada1);
            this.Controls.Add(this.label11);
            this.Name = "Paradas";
            this.Text = "Paradas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox total_parada2;
        private System.Windows.Forms.TextBox total_parada1;
        private System.Windows.Forms.ComboBox cb_paradafin1;
        private System.Windows.Forms.ComboBox cb_paradafin2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_parada2;
        private System.Windows.Forms.ComboBox cb_parada1;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tex_paradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nueva;
        // private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}