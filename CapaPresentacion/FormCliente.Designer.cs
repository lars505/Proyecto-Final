namespace CapaPresentacion
{
    partial class FormCliente
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.Id_Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtNombreP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidoM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.Btncancelar = new System.Windows.Forms.Button();
            this.Btnnuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(108, 30);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(48, 20);
            this.TxtId.TabIndex = 0;
            this.TxtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.AutoSize = true;
            this.Id_Cliente.Location = new System.Drawing.Point(16, 30);
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Size = new System.Drawing.Size(46, 13);
            this.Id_Cliente.TabIndex = 1;
            this.Id_Cliente.Text = "Codigo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre :";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(108, 56);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Location = new System.Drawing.Point(108, 82);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno :";
            // 
            // TxtApellidoM
            // 
            this.TxtApellidoM.Location = new System.Drawing.Point(108, 108);
            this.TxtApellidoM.Name = "TxtApellidoM";
            this.TxtApellidoM.Size = new System.Drawing.Size(100, 20);
            this.TxtApellidoM.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido Materno :";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(307, 30);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(307, 56);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefono.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Telefono :";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnApellidoP,
            this.ColumnApellidoM,
            this.ColumnDireccion,
            this.ColumnTelefono});
            this.dgvDatos.Location = new System.Drawing.Point(15, 156);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(682, 201);
            this.dgvDatos.TabIndex = 12;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellidoP
            // 
            this.ColumnApellidoP.HeaderText = "ApellidoP";
            this.ColumnApellidoP.Name = "ColumnApellidoP";
            // 
            // ColumnApellidoM
            // 
            this.ColumnApellidoM.HeaderText = "ApellidoM";
            this.ColumnApellidoM.Name = "ColumnApellidoM";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Direccion";
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Telefono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(324, 103);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 28);
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // Btncancelar
            // 
            this.Btncancelar.Location = new System.Drawing.Point(405, 103);
            this.Btncancelar.Name = "Btncancelar";
            this.Btncancelar.Size = new System.Drawing.Size(75, 28);
            this.Btncancelar.TabIndex = 20;
            this.Btncancelar.Text = "Cancelar";
            this.Btncancelar.UseVisualStyleBackColor = true;
            // 
            // Btnnuevo
            // 
            this.Btnnuevo.Location = new System.Drawing.Point(243, 103);
            this.Btnnuevo.Name = "Btnnuevo";
            this.Btnnuevo.Size = new System.Drawing.Size(75, 28);
            this.Btnnuevo.TabIndex = 19;
            this.Btnnuevo.Text = "Nuevo";
            this.Btnnuevo.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(622, 374);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 28);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(541, 374);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 28);
            this.BtnEditar.TabIndex = 21;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 416);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.Btncancelar);
            this.Controls.Add(this.Btnnuevo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtApellidoM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNombreP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_Cliente);
            this.Controls.Add(this.TxtId);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label Id_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtNombreP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidoM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button Btncancelar;
        private System.Windows.Forms.Button Btnnuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
    }
}