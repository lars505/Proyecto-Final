namespace CapaPresentacion
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlCategoria = new System.Windows.Forms.ComboBox();
            this.CkEstado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PBImagen = new System.Windows.Forms.PictureBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdproveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnAgreagr = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnImagen = new System.Windows.Forms.Button();
            this.ddlProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(84, 29);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 1;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(84, 65);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(84, 100);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Categoria";
            // 
            // ddlCategoria
            // 
            this.ddlCategoria.FormattingEnabled = true;
            this.ddlCategoria.Location = new System.Drawing.Point(265, 29);
            this.ddlCategoria.Name = "ddlCategoria";
            this.ddlCategoria.Size = new System.Drawing.Size(121, 21);
            this.ddlCategoria.TabIndex = 10;
            this.ddlCategoria.SelectedIndexChanged += new System.EventHandler(this.ddlCategoria_SelectedIndexChanged);
            // 
            // CkEstado
            // 
            this.CkEstado.AutoSize = true;
            this.CkEstado.Location = new System.Drawing.Point(265, 103);
            this.CkEstado.Name = "CkEstado";
            this.CkEstado.Size = new System.Drawing.Size(15, 14);
            this.CkEstado.TabIndex = 12;
            this.CkEstado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PBImagen
            // 
            this.PBImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBImagen.Location = new System.Drawing.Point(505, 9);
            this.PBImagen.Name = "PBImagen";
            this.PBImagen.Size = new System.Drawing.Size(220, 152);
            this.PBImagen.TabIndex = 13;
            this.PBImagen.TabStop = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnProducto,
            this.ColumnDescripcion,
            this.ColumnEstado,
            this.ColumnProveedor,
            this.ColumnCategoria,
            this.ColumnIdproveedor,
            this.ColumnIdcategoria});
            this.dgvDatos.Location = new System.Drawing.Point(15, 221);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(710, 268);
            this.dgvDatos.TabIndex = 14;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Codigo";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.HeaderText = "Descripcion";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnProveedor
            // 
            this.ColumnProveedor.HeaderText = "Proveedor";
            this.ColumnProveedor.Name = "ColumnProveedor";
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.Name = "ColumnCategoria";
            // 
            // ColumnIdproveedor
            // 
            this.ColumnIdproveedor.HeaderText = "Idproveedor";
            this.ColumnIdproveedor.Name = "ColumnIdproveedor";
            this.ColumnIdproveedor.Visible = false;
            // 
            // ColumnIdcategoria
            // 
            this.ColumnIdcategoria.HeaderText = "Idcategoria";
            this.ColumnIdcategoria.Name = "ColumnIdcategoria";
            this.ColumnIdcategoria.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(252, 167);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 28);
            this.BtnNuevo.TabIndex = 15;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnAgreagr
            // 
            this.BtnAgreagr.Location = new System.Drawing.Point(333, 167);
            this.BtnAgreagr.Name = "BtnAgreagr";
            this.BtnAgreagr.Size = new System.Drawing.Size(75, 28);
            this.BtnAgreagr.TabIndex = 16;
            this.BtnAgreagr.Text = "Agregar";
            this.BtnAgreagr.UseVisualStyleBackColor = true;
            this.BtnAgreagr.Click += new System.EventHandler(this.BtnAgreagr_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(569, 495);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 28);
            this.BtnEditar.TabIndex = 17;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(650, 495);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 28);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(414, 167);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 28);
            this.BtnCancelar.TabIndex = 19;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnImagen
            // 
            this.BtnImagen.Location = new System.Drawing.Point(685, 167);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(40, 28);
            this.BtnImagen.TabIndex = 20;
            this.BtnImagen.Text = "...";
            this.BtnImagen.UseVisualStyleBackColor = true;
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // ddlProveedor
            // 
            this.ddlProveedor.FormattingEnabled = true;
            this.ddlProveedor.Location = new System.Drawing.Point(265, 65);
            this.ddlProveedor.Name = "ddlProveedor";
            this.ddlProveedor.Size = new System.Drawing.Size(121, 21);
            this.ddlProveedor.TabIndex = 22;
            this.ddlProveedor.SelectedIndexChanged += new System.EventHandler(this.ddlProveedor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Proveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ddlProveedor);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombreProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ddlCategoria);
            this.groupBox1.Controls.Add(this.CkEstado);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 158);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 21);
            this.button2.TabIndex = 25;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 537);
            this.Controls.Add(this.BtnImagen);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgreagr);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.PBImagen);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlCategoria;
        private System.Windows.Forms.CheckBox CkEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PBImagen;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnAgreagr;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnImagen;
        private System.Windows.Forms.ComboBox ddlProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdcategoria;
    }
}