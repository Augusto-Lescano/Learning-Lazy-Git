namespace ConsumiendoEscritorio
{
    partial class CRUD_Alumno
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
            tablaListaAlumnos = new DataGridView();
            btnBuscar = new Button();
            txtNombre = new TextBox();
            labelApellido = new Label();
            labelLegajo = new Label();
            labelDireccion = new Label();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtLegajo = new TextBox();
            labelNombre = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnBorrar = new Button();
            label1 = new Label();
            btnListar = new Button();
            btnLimpiarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)tablaListaAlumnos).BeginInit();
            SuspendLayout();
            // 
            // tablaListaAlumnos
            // 
            tablaListaAlumnos.AllowUserToAddRows = false;
            tablaListaAlumnos.AllowUserToDeleteRows = false;
            tablaListaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaListaAlumnos.Location = new Point(12, 240);
            tablaListaAlumnos.Name = "tablaListaAlumnos";
            tablaListaAlumnos.ReadOnly = true;
            tablaListaAlumnos.Size = new Size(776, 198);
            tablaListaAlumnos.TabIndex = 0;
            tablaListaAlumnos.CellClick += tablaListaAlumnos_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(344, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar por legajo";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 3;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(12, 110);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(51, 15);
            labelApellido.TabIndex = 4;
            labelApellido.Text = "Apellido";
            // 
            // labelLegajo
            // 
            labelLegajo.AutoSize = true;
            labelLegajo.Location = new Point(12, 23);
            labelLegajo.Name = "labelLegajo";
            labelLegajo.Size = new Size(42, 15);
            labelLegajo.TabIndex = 5;
            labelLegajo.Text = "Legajo";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(12, 153);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(57, 15);
            labelDireccion.TabIndex = 6;
            labelDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(81, 145);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(225, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(81, 107);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(81, 20);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(225, 23);
            txtLegajo.TabIndex = 9;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(12, 67);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(344, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(344, 106);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(110, 23);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(344, 149);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 23);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 210);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 14;
            label1.Text = "Lista de Alumnos";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(564, 20);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(155, 23);
            btnListar.TabIndex = 15;
            btnListar.Text = "Listar alumnos";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnLimpiarDatos
            // 
            btnLimpiarDatos.Location = new Point(564, 59);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(155, 23);
            btnLimpiarDatos.TabIndex = 16;
            btnLimpiarDatos.Text = "Limpiar datos";
            btnLimpiarDatos.UseVisualStyleBackColor = true;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
            // 
            // CRUD_Alumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiarDatos);
            Controls.Add(btnListar);
            Controls.Add(label1);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(labelNombre);
            Controls.Add(txtLegajo);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(labelDireccion);
            Controls.Add(labelLegajo);
            Controls.Add(labelApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscar);
            Controls.Add(tablaListaAlumnos);
            Name = "CRUD_Alumno";
            Text = "Sistema de alumnos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tablaListaAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaListaAlumnos;
        private Button btnBuscar;
        private TextBox txtNombre;
        private Label labelApellido;
        private Label labelLegajo;
        private Label labelDireccion;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtLegajo;
        private Label labelNombre;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnBorrar;
        private Label label1;
        private Button btnListar;
        private Button btnLimpiarDatos;
    }
}
