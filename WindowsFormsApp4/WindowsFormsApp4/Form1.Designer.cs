using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblLugar;
        private TextBox txtLugar;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvTareas;

        private Label lblBuscarCodigo;
        private TextBox txtBuscarCodigo;
        private Label lblBuscarEstado;
        private ComboBox cmbBuscarEstado;
        private Label lblFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtpFechaFin;
        private CheckBox chkFiltrarRango;
        private Button btnBuscar;
        private Button btnMostrarTodo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCodigo = new Label();
            this.txtCodigo = new TextBox();
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblDescripcion = new Label();
            this.txtDescripcion = new TextBox();
            this.lblFecha = new Label();
            this.dtpFecha = new DateTimePicker();
            this.lblLugar = new Label();
            this.txtLugar = new TextBox();
            this.lblEstado = new Label();
            this.cmbEstado = new ComboBox();
            this.btnAgregar = new Button();
            this.btnEditar = new Button();
            this.btnEliminar = new Button();
            this.dgvTareas = new DataGridView();

            this.lblBuscarCodigo = new Label();
            this.txtBuscarCodigo = new TextBox();
            this.lblBuscarEstado = new Label();
            this.cmbBuscarEstado = new ComboBox();
            this.lblFechaInicio = new Label();
            this.dtpFechaInicio = new DateTimePicker();
            this.lblFechaFin = new Label();
            this.dtpFechaFin = new DateTimePicker();
            this.chkFiltrarRango = new CheckBox();
            this.btnBuscar = new Button();
            this.btnMostrarTodo = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();

            // lblCodigo
            lblCodigo.Text = "Código:"; lblCodigo.Location = new Point(20, 20);
            txtCodigo.Location = new Point(120, 17); txtCodigo.Size = new Size(200, 20);

            // lblNombre
            lblNombre.Text = "Nombre:"; lblNombre.Location = new Point(20, 50);
            txtNombre.Location = new Point(120, 47); txtNombre.Size = new Size(200, 20);

            // lblDescripcion
            lblDescripcion.Text = "Descripción:"; lblDescripcion.Location = new Point(20, 80);
            txtDescripcion.Location = new Point(120, 77); txtDescripcion.Size = new Size(200, 60); txtDescripcion.Multiline = true;

            // lblFecha
            lblFecha.Text = "Fecha de realización:"; lblFecha.Location = new Point(20, 150);
            dtpFecha.Location = new Point(140, 147); dtpFecha.Size = new Size(200, 20);

            // lblLugar
            lblLugar.Text = "Lugar:"; lblLugar.Location = new Point(20, 180);
            txtLugar.Location = new Point(120, 177); txtLugar.Size = new Size(200, 20);

            // lblEstado
            lblEstado.Text = "Estado:"; lblEstado.Location = new Point(20, 210);
            cmbEstado.Location = new Point(120, 207); cmbEstado.Size = new Size(200, 21);
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new object[] { "No realizada", "En proceso", "Terminada" });

            // Botones
            btnAgregar.Text = "Agregar Tarea"; btnAgregar.Location = new Point(20, 250); btnAgregar.Size = new Size(90, 30);
            btnAgregar.Click += new EventHandler(this.btnAgregar_Click);

            btnEditar.Text = "Editar Tarea"; btnEditar.Location = new Point(130, 250); btnEditar.Size = new Size(90, 30);
            btnEditar.Click += new EventHandler(this.btnEditar_Click);

            btnEliminar.Text = "Eliminar Tarea"; btnEliminar.Location = new Point(230, 250); btnEliminar.Size = new Size(90, 30);
            btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            // dgvTareas
            dgvTareas.Location = new Point(350, 20); dgvTareas.Size = new Size(420, 300);
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.AllowUserToAddRows = false; dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.CellClick += new DataGridViewCellEventHandler(this.dgvTareas_CellClick);

            // Controles de búsqueda
            lblBuscarCodigo.Text = "Buscar por Código:"; lblBuscarCodigo.Location = new Point(20, 330);
            txtBuscarCodigo.Location = new Point(120, 327); txtBuscarCodigo.Size = new Size(200, 20);

            lblBuscarEstado.Text = "Buscar por Estado:"; lblBuscarEstado.Location = new Point(20, 360);
            cmbBuscarEstado.Location = new Point(120, 357); cmbBuscarEstado.Size = new Size(200, 21);
            cmbBuscarEstado.Items.AddRange(new object[] { "No realizada", "En proceso", "Terminada" });

            // Fecha inicio y fin
            lblFechaInicio.Text = "Fecha Inicio:"; lblFechaInicio.Location = new Point(20, 390);
            dtpFechaInicio.Location = new Point(120, 387); dtpFechaInicio.Size = new Size(200, 20);

            lblFechaFin.Text = "Fecha Fin:"; lblFechaFin.Location = new Point(20, 420);
            dtpFechaFin.Location = new Point(120, 417); dtpFechaFin.Size = new Size(200, 20);

            chkFiltrarRango.Text = "Filtrar por rango de fecha"; chkFiltrarRango.Location = new Point(330, 387);

            // Botones de búsqueda
            btnBuscar.Text = "Buscar Tarea"; btnBuscar.Location = new Point(20, 450); btnBuscar.Size = new Size(120, 30);
            btnBuscar.Click += new EventHandler(this.btnBuscar_Click);

            btnMostrarTodo.Text = "Mostrar Todo"; btnMostrarTodo.Location = new Point(160, 450); btnMostrarTodo.Size = new Size(120, 30);
            btnMostrarTodo.Click += new EventHandler(this.btnMostrarTodo_Click);

            // Agregar controles
            this.Controls.AddRange(new Control[] {
                lblCodigo, txtCodigo,
                lblNombre, txtNombre,
                lblDescripcion, txtDescripcion,
                lblFecha, dtpFecha,
                lblLugar, txtLugar,
                lblEstado, cmbEstado,
                btnAgregar, btnEditar, btnEliminar,
                dgvTareas,
                lblBuscarCodigo, txtBuscarCodigo,
                lblBuscarEstado, cmbBuscarEstado,
                lblFechaInicio, dtpFechaInicio,
                lblFechaFin, dtpFechaFin,
                chkFiltrarRango,
                btnBuscar, btnMostrarTodo
            });

            this.ClientSize = new Size(800, 520);
            this.Text = "Gestor de Tareas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
