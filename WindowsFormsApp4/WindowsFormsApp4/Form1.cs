using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<Tarea> listaTareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Clear();
            cmbEstado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debes llenar al menos Código y Nombre.");
                return;
            }

            Tarea nueva = new Tarea()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "No realizada"
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
                LimpiarCampos();
            }
        }

        private void BuscarTareas()
        {
            var filtradas = listaTareas;

            if (!string.IsNullOrWhiteSpace(txtBuscarCodigo.Text))
                filtradas = filtradas.FindAll(t => t.Codigo.Contains(txtBuscarCodigo.Text));

            if (cmbBuscarEstado.SelectedIndex != -1)
                filtradas = filtradas.FindAll(t => t.Estado == cmbBuscarEstado.SelectedItem.ToString());

            if (chkFiltrarRango.Checked)
            {
                DateTime inicio = dtpFechaInicio.Value.Date;
                DateTime fin = dtpFechaFin.Value.Date;
                filtradas = filtradas.FindAll(t => t.Fecha.Date >= inicio && t.Fecha.Date <= fin);
            }

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = filtradas;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTareas();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            txtBuscarCodigo.Clear();
            cmbBuscarEstado.SelectedIndex = -1;
            chkFiltrarRango.Checked = false;
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
