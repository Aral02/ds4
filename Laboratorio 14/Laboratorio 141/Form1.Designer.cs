using System.Data;
using System.Data.SqlClient;
namespace Laboratorio_141
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            tsbBuscar = new PictureBox();
            tsbCancelar = new PictureBox();
            tsbEliminar = new PictureBox();
            tsbGuardar = new PictureBox();
            tsbNuevo = new PictureBox();
            label1 = new Label();
            tstId = new TextBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).BeginInit();
            SuspendLayout();
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.Location = new Point(427, 16);
            tsbBuscar.Margin = new Padding(7);
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Padding = new Padding(5);
            tsbBuscar.Size = new Size(28, 28);
            tsbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbBuscar.TabIndex = 0;
            tsbBuscar.TabStop = false;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbCancelar
            // 
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.Location = new Point(100, 16);
            tsbCancelar.Margin = new Padding(7);
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Padding = new Padding(5);
            tsbCancelar.Size = new Size(28, 28);
            tsbCancelar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbCancelar.TabIndex = 1;
            tsbCancelar.TabStop = false;
            tsbCancelar.Click += tsbCancelar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.Location = new Point(142, 16);
            tsbEliminar.Margin = new Padding(7);
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Padding = new Padding(5);
            tsbEliminar.Size = new Size(28, 28);
            tsbEliminar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbEliminar.TabIndex = 2;
            tsbEliminar.TabStop = false;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbGuardar
            // 
            tsbGuardar.Image = (Image)resources.GetObject("tsbGuardar.Image");
            tsbGuardar.Location = new Point(58, 16);
            tsbGuardar.Margin = new Padding(7);
            tsbGuardar.Name = "tsbGuardar";
            tsbGuardar.Padding = new Padding(5);
            tsbGuardar.Size = new Size(28, 28);
            tsbGuardar.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbGuardar.TabIndex = 3;
            tsbGuardar.TabStop = false;
            tsbGuardar.Click += tsbGuardar_Click;
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.Location = new Point(16, 16);
            tsbNuevo.Margin = new Padding(7);
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Padding = new Padding(5);
            tsbNuevo.Size = new Size(28, 28);
            tsbNuevo.SizeMode = PictureBoxSizeMode.StretchImage;
            tsbNuevo.TabIndex = 4;
            tsbNuevo.TabStop = false;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "Buscar por ID:";
            // 
            // tstId
            // 
            tstId.Location = new Point(287, 16);
            tstId.Name = "tstId";
            tstId.Size = new Size(130, 27);
            tstId.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 110);
            txtId.Name = "txtId";
            txtId.Size = new Size(134, 27);
            txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(264, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(429, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(29, 183);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(129, 27);
            txtPrecio.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(264, 183);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(165, 27);
            txtStock.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 87);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 87);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 160);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 13;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 160);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 14;
            label5.Text = "Stock";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(29, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 44);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 291);
            Controls.Add(btnSalir);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(tstId);
            Controls.Add(label1);
            Controls.Add(tsbNuevo);
            Controls.Add(tsbGuardar);
            Controls.Add(tsbEliminar);
            Controls.Add(tsbCancelar);
            Controls.Add(tsbBuscar);
            Name = "frmProductos";
            Text = "Form1";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)tsbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbCancelar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbEliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbGuardar).EndInit();
            ((System.ComponentModel.ISupportInitialize)tsbNuevo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tsbBuscar;
        private PictureBox tsbCancelar;
        private PictureBox tsbEliminar;
        private PictureBox tsbGuardar;
        private PictureBox tsbNuevo;
        private Label label1;
        private TextBox tstId;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSalir;
    }
}
