namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_turno1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_hora = new System.Windows.Forms.DateTimePicker();
            this.cb_turno2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub_totales = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_turno_fin2 = new System.Windows.Forms.ComboBox();
            this.cb_turno_fin1 = new System.Windows.Forms.ComboBox();
            this.total_horas1 = new System.Windows.Forms.TextBox();
            this.total_horas2 = new System.Windows.Forms.TextBox();
            this.cb_comida1 = new System.Windows.Forms.ComboBox();
            this.cb_comida2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_comidafin1 = new System.Windows.Forms.ComboBox();
            this.cb_comidafin2 = new System.Windows.Forms.ComboBox();
            this.total_comida2 = new System.Windows.Forms.TextBox();
            this.total_comida1 = new System.Windows.Forms.TextBox();
            this.cb_total_hr_netas = new System.Windows.Forms.TextBox();
            this.cb_total_hr_totales = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.boton_P = new System.Windows.Forms.Button();
            this.cb_total_hr_netas2 = new System.Windows.Forms.TextBox();
            this.cb_total_hr_totales2 = new System.Windows.Forms.TextBox();
            this.paradas_acumuladas = new System.Windows.Forms.TextBox();
            this.cb_sector = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_turno1
            // 
            this.cb_turno1.FormattingEnabled = true;
            this.cb_turno1.Location = new System.Drawing.Point(84, 89);
            this.cb_turno1.Name = "cb_turno1";
            this.cb_turno1.Size = new System.Drawing.Size(70, 21);
            this.cb_turno1.TabIndex = 0;
            this.cb_turno1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "T 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HORARIOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "T 2";
            // 
            // dt_hora
            // 
            this.dt_hora.Location = new System.Drawing.Point(40, 25);
            this.dt_hora.Name = "dt_hora";
            this.dt_hora.Size = new System.Drawing.Size(148, 20);
            this.dt_hora.TabIndex = 5;
            this.dt_hora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cb_turno2
            // 
            this.cb_turno2.FormattingEnabled = true;
            this.cb_turno2.Location = new System.Drawing.Point(168, 89);
            this.cb_turno2.Name = "cb_turno2";
            this.cb_turno2.Size = new System.Drawing.Size(70, 21);
            this.cb_turno2.TabIndex = 6;
            this.cb_turno2.SelectedIndexChanged += new System.EventHandler(this.cb_turno2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inicio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Finaliza";
            // 
            // sub_totales
            // 
            this.sub_totales.AutoSize = true;
            this.sub_totales.Location = new System.Drawing.Point(22, 150);
            this.sub_totales.Name = "sub_totales";
            this.sub_totales.Size = new System.Drawing.Size(56, 13);
            this.sub_totales.TabIndex = 9;
            this.sub_totales.Text = "Sub_Total";
            this.sub_totales.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "COMIDA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cb_turno_fin2
            // 
            this.cb_turno_fin2.FormattingEnabled = true;
            this.cb_turno_fin2.Location = new System.Drawing.Point(168, 116);
            this.cb_turno_fin2.Name = "cb_turno_fin2";
            this.cb_turno_fin2.Size = new System.Drawing.Size(70, 21);
            this.cb_turno_fin2.TabIndex = 11;
            this.cb_turno_fin2.SelectedIndexChanged += new System.EventHandler(this.cb_turno_fin2_SelectedIndexChanged);
            // 
            // cb_turno_fin1
            // 
            this.cb_turno_fin1.FormattingEnabled = true;
            this.cb_turno_fin1.Location = new System.Drawing.Point(84, 116);
            this.cb_turno_fin1.Name = "cb_turno_fin1";
            this.cb_turno_fin1.Size = new System.Drawing.Size(70, 21);
            this.cb_turno_fin1.TabIndex = 12;
            this.cb_turno_fin1.SelectedIndexChanged += new System.EventHandler(this.cb_turno_fin1_SelectedIndexChanged);
            // 
            // total_horas1
            // 
            this.total_horas1.Location = new System.Drawing.Point(84, 143);
            this.total_horas1.Name = "total_horas1";
            this.total_horas1.Size = new System.Drawing.Size(70, 20);
            this.total_horas1.TabIndex = 13;
            this.total_horas1.TextChanged += new System.EventHandler(this.total_horas_TextChanged);
            // 
            // total_horas2
            // 
            this.total_horas2.Location = new System.Drawing.Point(168, 143);
            this.total_horas2.Name = "total_horas2";
            this.total_horas2.Size = new System.Drawing.Size(70, 20);
            this.total_horas2.TabIndex = 14;
            this.total_horas2.TextChanged += new System.EventHandler(this.total_horas2_TextChanged);
            // 
            // cb_comida1
            // 
            this.cb_comida1.FormattingEnabled = true;
            this.cb_comida1.Location = new System.Drawing.Point(261, 89);
            this.cb_comida1.Name = "cb_comida1";
            this.cb_comida1.Size = new System.Drawing.Size(70, 21);
            this.cb_comida1.TabIndex = 16;
            this.cb_comida1.SelectedIndexChanged += new System.EventHandler(this.comida1_SelectedIndexChanged);
            // 
            // cb_comida2
            // 
            this.cb_comida2.FormattingEnabled = true;
            this.cb_comida2.Location = new System.Drawing.Point(345, 89);
            this.cb_comida2.Name = "cb_comida2";
            this.cb_comida2.Size = new System.Drawing.Size(70, 21);
            this.cb_comida2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "T 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "T 1";
            // 
            // cb_comidafin1
            // 
            this.cb_comidafin1.FormattingEnabled = true;
            this.cb_comidafin1.Location = new System.Drawing.Point(261, 116);
            this.cb_comidafin1.Name = "cb_comidafin1";
            this.cb_comidafin1.Size = new System.Drawing.Size(70, 21);
            this.cb_comidafin1.TabIndex = 21;
            this.cb_comidafin1.SelectedIndexChanged += new System.EventHandler(this.cb_comidafin1_SelectedIndexChanged);
            // 
            // cb_comidafin2
            // 
            this.cb_comidafin2.FormattingEnabled = true;
            this.cb_comidafin2.Location = new System.Drawing.Point(345, 116);
            this.cb_comidafin2.Name = "cb_comidafin2";
            this.cb_comidafin2.Size = new System.Drawing.Size(70, 21);
            this.cb_comidafin2.TabIndex = 20;
            this.cb_comidafin2.SelectedIndexChanged += new System.EventHandler(this.cb_comidafin2_SelectedIndexChanged);
            // 
            // total_comida2
            // 
            this.total_comida2.Location = new System.Drawing.Point(345, 143);
            this.total_comida2.Name = "total_comida2";
            this.total_comida2.Size = new System.Drawing.Size(70, 20);
            this.total_comida2.TabIndex = 23;
            this.total_comida2.TextChanged += new System.EventHandler(this.total_comida2_TextChanged);
            // 
            // total_comida1
            // 
            this.total_comida1.Location = new System.Drawing.Point(261, 143);
            this.total_comida1.Name = "total_comida1";
            this.total_comida1.Size = new System.Drawing.Size(70, 20);
            this.total_comida1.TabIndex = 22;
            this.total_comida1.TextChanged += new System.EventHandler(this.total_comida1_TextChanged);
            // 
            // cb_total_hr_netas
            // 
            this.cb_total_hr_netas.Location = new System.Drawing.Point(168, 181);
            this.cb_total_hr_netas.Name = "cb_total_hr_netas";
            this.cb_total_hr_netas.Size = new System.Drawing.Size(70, 20);
            this.cb_total_hr_netas.TabIndex = 33;
            this.cb_total_hr_netas.TextChanged += new System.EventHandler(this.cb_total_hr_netas_TextChanged);
            // 
            // cb_total_hr_totales
            // 
            this.cb_total_hr_totales.Location = new System.Drawing.Point(168, 207);
            this.cb_total_hr_totales.Name = "cb_total_hr_totales";
            this.cb_total_hr_totales.Size = new System.Drawing.Size(70, 20);
            this.cb_total_hr_totales.TabIndex = 34;
            this.cb_total_hr_totales.TextChanged += new System.EventHandler(this.cb_total_hr_totales_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Hr Netas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(110, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Hr Totales";
            // 
            // boton_P
            // 
            this.boton_P.Location = new System.Drawing.Point(425, 152);
            this.boton_P.Name = "boton_P";
            this.boton_P.Size = new System.Drawing.Size(75, 23);
            this.boton_P.TabIndex = 38;
            this.boton_P.Text = "PARADAS";
            this.boton_P.UseVisualStyleBackColor = true;
            this.boton_P.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_total_hr_netas2
            // 
            this.cb_total_hr_netas2.Location = new System.Drawing.Point(244, 181);
            this.cb_total_hr_netas2.Name = "cb_total_hr_netas2";
            this.cb_total_hr_netas2.Size = new System.Drawing.Size(70, 20);
            this.cb_total_hr_netas2.TabIndex = 43;
            // 
            // cb_total_hr_totales2
            // 
            this.cb_total_hr_totales2.Location = new System.Drawing.Point(244, 207);
            this.cb_total_hr_totales2.Name = "cb_total_hr_totales2";
            this.cb_total_hr_totales2.Size = new System.Drawing.Size(70, 20);
            this.cb_total_hr_totales2.TabIndex = 44;
            this.cb_total_hr_totales2.TextChanged += new System.EventHandler(this.cb_total_hr_totales2_TextChanged);
            // 
            // paradas_acumuladas
            // 
            this.paradas_acumuladas.Location = new System.Drawing.Point(425, 181);
            this.paradas_acumuladas.Name = "paradas_acumuladas";
            this.paradas_acumuladas.Size = new System.Drawing.Size(129, 20);
            this.paradas_acumuladas.TabIndex = 46;
            this.paradas_acumuladas.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cb_sector
            // 
            this.cb_sector.FormattingEnabled = true;
            this.cb_sector.Location = new System.Drawing.Point(244, 25);
            this.cb_sector.Name = "cb_sector";
            this.cb_sector.Size = new System.Drawing.Size(88, 21);
            this.cb_sector.TabIndex = 47;
            this.cb_sector.SelectedIndexChanged += new System.EventHandler(this.cb_sector_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "FECHA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "SECTOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_sector);
            this.Controls.Add(this.paradas_acumuladas);
            this.Controls.Add(this.cb_total_hr_totales2);
            this.Controls.Add(this.cb_total_hr_netas2);
            this.Controls.Add(this.boton_P);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_total_hr_totales);
            this.Controls.Add(this.cb_total_hr_netas);
            this.Controls.Add(this.total_comida2);
            this.Controls.Add(this.total_comida1);
            this.Controls.Add(this.cb_comidafin1);
            this.Controls.Add(this.cb_comidafin2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_comida2);
            this.Controls.Add(this.cb_comida1);
            this.Controls.Add(this.total_horas2);
            this.Controls.Add(this.total_horas1);
            this.Controls.Add(this.cb_turno_fin1);
            this.Controls.Add(this.cb_turno_fin2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sub_totales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_turno2);
            this.Controls.Add(this.dt_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_turno1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_turno1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_hora;
        private System.Windows.Forms.ComboBox cb_turno2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sub_totales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_turno_fin2;
        private System.Windows.Forms.ComboBox cb_turno_fin1;
        private System.Windows.Forms.TextBox total_horas1;
        private System.Windows.Forms.TextBox total_horas2;
        private System.Windows.Forms.ComboBox cb_comida1;
        private System.Windows.Forms.ComboBox cb_comida2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_comidafin1;
        private System.Windows.Forms.ComboBox cb_comidafin2;
        private System.Windows.Forms.TextBox total_comida2;
        private System.Windows.Forms.TextBox total_comida1;
        private System.Windows.Forms.TextBox cb_total_hr_totales;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button boton_P;
        public System.Windows.Forms.TextBox cb_total_hr_netas2;
        private System.Windows.Forms.TextBox cb_total_hr_totales2;
        public System.Windows.Forms.TextBox paradas_acumuladas;
        public System.Windows.Forms.TextBox cb_total_hr_netas;
        private System.Windows.Forms.ComboBox cb_sector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
    }
}

