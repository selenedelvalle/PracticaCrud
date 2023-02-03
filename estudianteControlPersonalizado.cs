using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaCrud.Clases;

namespace PracticaCrud
{
    public partial class estudianteControlPersonalizado : UserControl
    {
        Estudiante es = new Estudiante();
        Transacciones t = new Transacciones();
        public estudianteControlPersonalizado()
        {
            InitializeComponent();
            cargar();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }
        private void cargar() 
        {
            this.dgvTabla.DataSource = t.consultar("Estudiante");
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void set ()
        {
            this.es.matricula = int.Parse(txtMatricula.Text);
            this.es.nombre = txtNombre.Text;
            this.es.apellidos = txtApellido.Text;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            set();
            if (t.insertar("Estudiante", this.es)) 
            {
                MessageBox.Show("Registro guardado con exito");
                cargar();
            }
        }
    }
}
