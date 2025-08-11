namespace ExamenPOOAgosto2025Alt.Windows
{
    partial class frmVentasAE
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
            components = new System.ComponentModel.Container();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTipoProducto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTotal = new TextBox();
            nudCantidad = new NumericUpDown();
            btnCancelar = new Button();
            btnOk = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(161, 158);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(98, 23);
            txtStock.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(161, 116);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(98, 23);
            txtPrecio.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 161);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Stock:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(159, 75);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(356, 23);
            txtDescripcion.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 119);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio Unit.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 78);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 6;
            label1.Text = "Tipo Producto:";
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.Location = new Point(161, 36);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new Size(255, 23);
            txtTipoProducto.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 161);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 119);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 4;
            label6.Text = "Precio Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(380, 116);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(98, 23);
            txtTotal.TabIndex = 9;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(380, 159);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(105, 23);
            nudCantidad.TabIndex = 11;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(419, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 60);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.ok_24px;
            btnOk.Location = new Point(36, 226);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(96, 60);
            btnOk.TabIndex = 13;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmVentasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 306);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(nudCantidad);
            Controls.Add(txtTipoProducto);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(562, 345);
            MinimumSize = new Size(562, 345);
            Name = "frmVentasAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVentasAE";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTipoProducto;
        private Label label5;
        private Label label6;
        private TextBox txtTotal;
        private NumericUpDown nudCantidad;
        private Button btnCancelar;
        private Button btnOk;
        private ErrorProvider errorProvider1;
    }
}