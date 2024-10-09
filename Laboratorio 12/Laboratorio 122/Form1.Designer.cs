namespace Laboratorio_122
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N3 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Avg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(234, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTA PROMEDIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOTA NO. 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOTA NO. 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOTA NO. 3";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "PROMEDIO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(225, 107);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(226, 22);
            this.N1.TabIndex = 5;
            // 
            // N3
            // 
            this.N3.Location = new System.Drawing.Point(225, 228);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(226, 22);
            this.N3.TabIndex = 6;
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(225, 164);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(226, 22);
            this.N2.TabIndex = 7;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(122, 275);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(93, 41);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(301, 275);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 41);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(481, 275);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(93, 41);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Avg
            // 
            this.Avg.Location = new System.Drawing.Point(225, 343);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(226, 22);
            this.Avg.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Avg);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.TextBox N3;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox Avg;
    }
}

