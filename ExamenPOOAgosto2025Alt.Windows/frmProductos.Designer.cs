namespace ExamenPOOAgosto2025Alt.Windows
{
    partial class frmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbFiltrar = new ToolStripDropDownButton();
            TcboMateriales = new ToolStripComboBox();
            TsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbVentas = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbSalir = new ToolStripButton();
            panelInferior = new Panel();
            TxtCantidadFiguras = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelInferior.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbEditar, toolStripSeparator1, TsbFiltrar, TsbActualizar, toolStripSeparator2, tsbVentas, toolStripSeparator3, TsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 70);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.add_file_48px;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(52, 67);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Properties.Resources.delete_file_48px;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(52, 67);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Properties.Resources.edit_file_48px;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(52, 67);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 70);
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { TcboMateriales });
            TsbFiltrar.Image = Properties.Resources.filled_filter_48px;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(61, 67);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TcboMateriales
            // 
            TcboMateriales.Name = "TcboMateriales";
            TcboMateriales.Size = new Size(121, 23);
            // 
            // TsbActualizar
            // 
            TsbActualizar.Image = Properties.Resources.restart_48px;
            TsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizar.ImageTransparentColor = Color.Magenta;
            TsbActualizar.Name = "TsbActualizar";
            TsbActualizar.Size = new Size(63, 67);
            TsbActualizar.Text = "Actualizar";
            TsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 70);
            // 
            // tsbVentas
            // 
            tsbVentas.Image = Properties.Resources.buy_48px;
            tsbVentas.ImageScaling = ToolStripItemImageScaling.None;
            tsbVentas.ImageTransparentColor = Color.Magenta;
            tsbVentas.Name = "tsbVentas";
            tsbVentas.Size = new Size(52, 67);
            tsbVentas.Text = "Ventas";
            tsbVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 70);
            // 
            // TsbSalir
            // 
            TsbSalir.Image = Properties.Resources.exit_48px;
            TsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            TsbSalir.ImageTransparentColor = Color.Magenta;
            TsbSalir.Name = "TsbSalir";
            TsbSalir.Size = new Size(52, 67);
            TsbSalir.Text = "Salir";
            TsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(TxtCantidadFiguras);
            panelInferior.Controls.Add(label1);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 373);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(800, 77);
            panelInferior.TabIndex = 1;
            // 
            // TxtCantidadFiguras
            // 
            TxtCantidadFiguras.Location = new Point(162, 24);
            TxtCantidadFiguras.Name = "TxtCantidadFiguras";
            TxtCantidadFiguras.ReadOnly = true;
            TxtCantidadFiguras.Size = new Size(100, 23);
            TxtCantidadFiguras.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de Figuras:";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 303);
            panel1.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colTipo, colDescripcion, colPrecio, colStock });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Size = new Size(800, 303);
            dgvDatos.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colTipo
            // 
            colTipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipo.HeaderText = "Tipo Prod.";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "P. Unit.";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelInferior);
            Controls.Add(toolStrip1);
            Name = "frmProductos";
            Text = "FrmFiguras3D";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsbSalir;
        private Panel panelInferior;
        private Panel panel1;
        private DataGridView dgvDatos;
        private ToolStripDropDownButton TsbFiltrar;
        private TextBox TxtCantidadFiguras;
        private Label label1;
        private ToolStripComboBox TcboMateriales;
        private ToolStripButton tsbVentas;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
    }
}