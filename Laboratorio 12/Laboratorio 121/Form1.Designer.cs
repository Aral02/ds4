namespace Laboratorio_121
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
            this.VEL = new System.Windows.Forms.TextBox();
            this.TIME = new System.Windows.Forms.TextBox();
            this.RES = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(199, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE DISTANCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "VELOCIDAD:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIEMPO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            // 
            // VEL
            // 
            this.VEL.Location = new System.Drawing.Point(204, 131);
            this.VEL.Name = "VEL";
            this.VEL.Size = new System.Drawing.Size(181, 22);
            this.VEL.TabIndex = 4;
            this.VEL.TextChanged += new System.EventHandler(this.VEL_TextChanged);
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(204, 206);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(181, 22);
            this.TIME.TabIndex = 5;
            // 
            // RES
            // 
            this.RES.Location = new System.Drawing.Point(204, 326);
            this.RES.Name = "RES";
            this.RES.Size = new System.Drawing.Size(181, 22);
            this.RES.TabIndex = 6;
            this.RES.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(70, 256);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(100, 43);
            this.btn_Calculate.TabIndex = 7;
            this.btn_Calculate.Text = "CALCULAR";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(236, 256);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 43);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(407, 256);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 43);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.RES);
            this.Controls.Add(this.TIME);
            this.Controls.Add(this.VEL);
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
        private System.Windows.Forms.TextBox VEL;
        private System.Windows.Forms.TextBox TIME;
        private System.Windows.Forms.TextBox RES;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
    }
}

