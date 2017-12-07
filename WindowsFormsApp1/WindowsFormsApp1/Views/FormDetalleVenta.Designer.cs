﻿namespace WindowsFormsApp1.Views
{
    partial class FormDetalleVenta
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
            this.B_Editar = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Mostrar = new System.Windows.Forms.Button();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.tb_SubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Factura = new System.Windows.Forms.ComboBox();
            this.cb_Venta = new System.Windows.Forms.ComboBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_Restablecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Editar
            // 
            this.B_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Editar.AutoSize = true;
            this.B_Editar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Editar.Image = global::WindowsFormsApp1.Properties.Resources.pencil;
            this.B_Editar.Location = new System.Drawing.Point(496, 47);
            this.B_Editar.Name = "B_Editar";
            this.B_Editar.Size = new System.Drawing.Size(141, 29);
            this.B_Editar.TabIndex = 29;
            this.B_Editar.Text = "Editar";
            this.B_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Editar.UseVisualStyleBackColor = true;
            this.B_Editar.Click += new System.EventHandler(this.B_Editar_Click);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Eliminar.AutoSize = true;
            this.B_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Eliminar.Image = global::WindowsFormsApp1.Properties.Resources.trash;
            this.B_Eliminar.Location = new System.Drawing.Point(496, 82);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(141, 29);
            this.B_Eliminar.TabIndex = 28;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 397);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 27;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Factura";
            // 
            // tb_Id
            // 
            this.tb_Id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(149, 14);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(341, 27);
            this.tb_Id.TabIndex = 22;
            this.tb_Id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // B_Mostrar
            // 
            this.B_Mostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Mostrar.AutoSize = true;
            this.B_Mostrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Mostrar.Image = global::WindowsFormsApp1.Properties.Resources.eye;
            this.B_Mostrar.Location = new System.Drawing.Point(496, 187);
            this.B_Mostrar.Name = "B_Mostrar";
            this.B_Mostrar.Size = new System.Drawing.Size(141, 29);
            this.B_Mostrar.TabIndex = 20;
            this.B_Mostrar.Text = "Mostrar";
            this.B_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Mostrar.UseVisualStyleBackColor = true;
            this.B_Mostrar.Click += new System.EventHandler(this.B_Mostrar_Click);
            // 
            // B_Agregar
            // 
            this.B_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Agregar.AutoSize = true;
            this.B_Agregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Agregar.Image = global::WindowsFormsApp1.Properties.Resources.plus;
            this.B_Agregar.Location = new System.Drawing.Point(496, 12);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(141, 29);
            this.B_Agregar.TabIndex = 19;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(625, 172);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Producto";
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Cantidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cantidad.Location = new System.Drawing.Point(149, 189);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(341, 27);
            this.tb_Cantidad.TabIndex = 33;
            // 
            // tb_SubTotal
            // 
            this.tb_SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SubTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SubTotal.Location = new System.Drawing.Point(149, 119);
            this.tb_SubTotal.Name = "tb_SubTotal";
            this.tb_SubTotal.Size = new System.Drawing.Size(341, 27);
            this.tb_SubTotal.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Subtotal";
            // 
            // cb_Factura
            // 
            this.cb_Factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Factura.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Factura.FormattingEnabled = true;
            this.cb_Factura.Location = new System.Drawing.Point(149, 49);
            this.cb_Factura.Name = "cb_Factura";
            this.cb_Factura.Size = new System.Drawing.Size(341, 27);
            this.cb_Factura.TabIndex = 36;
            // 
            // cb_Venta
            // 
            this.cb_Venta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Venta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Venta.FormattingEnabled = true;
            this.cb_Venta.Location = new System.Drawing.Point(149, 84);
            this.cb_Venta.Name = "cb_Venta";
            this.cb_Venta.Size = new System.Drawing.Size(341, 27);
            this.cb_Venta.TabIndex = 37;
            // 
            // cb_Producto
            // 
            this.cb_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Producto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(149, 154);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(341, 27);
            this.cb_Producto.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Logomakr_2VxCJc;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // B_Restablecer
            // 
            this.B_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Restablecer.AutoSize = true;
            this.B_Restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Restablecer.Image = global::WindowsFormsApp1.Properties.Resources.eraser;
            this.B_Restablecer.Location = new System.Drawing.Point(496, 117);
            this.B_Restablecer.Name = "B_Restablecer";
            this.B_Restablecer.Size = new System.Drawing.Size(141, 29);
            this.B_Restablecer.TabIndex = 40;
            this.B_Restablecer.Text = "Restablecer";
            this.B_Restablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Restablecer.UseVisualStyleBackColor = true;
            this.B_Restablecer.Click += new System.EventHandler(this.B_Restablecer_Click);
            // 
            // FormDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(649, 425);
            this.Controls.Add(this.B_Restablecer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_Producto);
            this.Controls.Add(this.cb_Venta);
            this.Controls.Add(this.cb_Factura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Cantidad);
            this.Controls.Add(this.tb_SubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.B_Editar);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Mostrar);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(665, 463);
            this.Name = "FormDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Detalles de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Editar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Mostrar;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.TextBox tb_SubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Factura;
        private System.Windows.Forms.ComboBox cb_Venta;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button B_Restablecer;
    }
}