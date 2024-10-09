namespace Laboratorio_123
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
            this.A = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.AREA = new System.Windows.Forms.TextBox();
            this.btn_s = new System.Windows.Forms.Button();
            this.btn_area = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Lado A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el Lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el Lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semiperimetro";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(247, 41);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(93, 22);
            this.A.TabIndex = 5;
            this.A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(169, 235);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(93, 22);
            this.P.TabIndex = 6;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(247, 130);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(93, 22);
            this.C.TabIndex = 7;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(247, 86);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(93, 22);
            this.B.TabIndex = 8;
            // 
            // AREA
            // 
            this.AREA.Location = new System.Drawing.Point(169, 284);
            this.AREA.Name = "AREA";
            this.AREA.Size = new System.Drawing.Size(93, 22);
            this.AREA.TabIndex = 9;
            // 
            // btn_s
            // 
            this.btn_s.Location = new System.Drawing.Point(12, 171);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(137, 41);
            this.btn_s.TabIndex = 10;
            this.btn_s.Text = "Calc. Semiperimetro";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_area
            // 
            this.btn_area.Location = new System.Drawing.Point(169, 171);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(104, 41);
            this.btn_area.TabIndex = 11;
            this.btn_area.Text = "Calc. Area";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(303, 171);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 41);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(439, 171);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(104, 41);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.btn_s);
            this.Controls.Add(this.AREA);
            this.Controls.Add(this.B);
            this.Controls.Add(this.C);
            this.Controls.Add(this.P);
            this.Controls.Add(this.A);
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
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox P;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox AREA;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
    }
}

