namespace ExamenPOOAgosto2025Alt.Windows
{
    partial class frmProductosAE
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
            label1 = new Label();
            cboTipoProducto = new ComboBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            label4 = new Label();
            txtStock = new TextBox();
            lblFechaPublicacion = new Label();
            dtpFechaPublicacion = new DateTimePicker();
            lblAutor = new Label();
            lblCantPaginas = new Label();
            txtAutor = new TextBox();
            textBox2 = new TextBox();
            lblNroEdicion = new Label();
            lblPeriodicidad = new Label();
            txtNroEdicion = new TextBox();
            txtPeriodicidad = new TextBox();
            btnOk = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 45);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo Producto:";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(154, 42);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(167, 23);
            cboTipoProducto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 105);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(152, 102);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(356, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 146);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(154, 143);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(98, 23);
            txtPrecio.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 188);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 0;
            label4.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(154, 185);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(98, 23);
            txtStock.TabIndex = 2;
            // 
            // lblFechaPublicacion
            // 
            lblFechaPublicacion.AutoSize = true;
            lblFechaPublicacion.Location = new Point(381, 44);
            lblFechaPublicacion.Name = "lblFechaPublicacion";
            lblFechaPublicacion.Size = new Size(106, 15);
            lblFechaPublicacion.TabIndex = 3;
            lblFechaPublicacion.Text = "Fecha Publicación:";
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.Format = DateTimePickerFormat.Short;
            dtpFechaPublicacion.Location = new Point(508, 39);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.Size = new Size(104, 23);
            dtpFechaPublicacion.TabIndex = 4;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(381, 146);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 0;
            lblAutor.Text = "Autor:";
            // 
            // lblCantPaginas
            // 
            lblCantPaginas.AutoSize = true;
            lblCantPaginas.Location = new Point(381, 188);
            lblCantPaginas.Name = "lblCantPaginas";
            lblCantPaginas.Size = new Size(82, 15);
            lblCantPaginas.TabIndex = 0;
            lblCantPaginas.Text = "Cant. Páginas:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(469, 143);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(333, 23);
            txtAutor.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(469, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 23);
            textBox2.TabIndex = 2;
            // 
            // lblNroEdicion
            // 
            lblNroEdicion.AutoSize = true;
            lblNroEdicion.Location = new Point(44, 236);
            lblNroEdicion.Name = "lblNroEdicion";
            lblNroEdicion.Size = new Size(75, 15);
            lblNroEdicion.TabIndex = 0;
            lblNroEdicion.Text = "Nro. Edición:";
            // 
            // lblPeriodicidad
            // 
            lblPeriodicidad.AutoSize = true;
            lblPeriodicidad.Location = new Point(44, 278);
            lblPeriodicidad.Name = "lblPeriodicidad";
            lblPeriodicidad.Size = new Size(39, 15);
            lblPeriodicidad.TabIndex = 0;
            lblPeriodicidad.Text = "Stock:";
            // 
            // txtNroEdicion
            // 
            txtNroEdicion.Location = new Point(154, 233);
            txtNroEdicion.Name = "txtNroEdicion";
            txtNroEdicion.Size = new Size(98, 23);
            txtNroEdicion.TabIndex = 2;
            // 
            // txtPeriodicidad
            // 
            txtPeriodicidad.Location = new Point(154, 275);
            txtPeriodicidad.Name = "txtPeriodicidad";
            txtPeriodicidad.Size = new Size(354, 23);
            txtPeriodicidad.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Image = Properties.Resources.ok_24px;
            btnOk.Location = new Point(47, 342);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(96, 60);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(706, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 60);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmProductosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(dtpFechaPublicacion);
            Controls.Add(lblFechaPublicacion);
            Controls.Add(textBox2);
            Controls.Add(txtAutor);
            Controls.Add(txtPeriodicidad);
            Controls.Add(txtStock);
            Controls.Add(txtNroEdicion);
            Controls.Add(lblCantPaginas);
            Controls.Add(lblPeriodicidad);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(lblAutor);
            Controls.Add(lblNroEdicion);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(cboTipoProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(864, 489);
            MinimumSize = new Size(864, 489);
            Name = "frmProductosAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductosAE";
            Load += frmProductosAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboTipoProducto;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtPrecio;
        private Label label4;
        private TextBox txtStock;
        private Label lblFechaPublicacion;
        private DateTimePicker dtpFechaPublicacion;
        private Label lblAutor;
        private Label lblCantPaginas;
        private TextBox txtAutor;
        private TextBox textBox2;
        private Label lblNroEdicion;
        private Label lblPeriodicidad;
        private TextBox txtNroEdicion;
        private TextBox txtPeriodicidad;
        private Button btnOk;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
    }
}