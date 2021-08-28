using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormulariosTarea1
{
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
        }

      
        private void Guardar_Click(object sender, EventArgs e)
        {
            if(BoxNombre.Text == "" | BoxApellidoP.Text == "" | BoxApellidoM.Text == "")
            {
                MessageBox.Show("Ningun campo puede quedar vacio","Error en formulario");

            }
            else
            {
                GridEstudiantes.Rows.Add(BoxNombre.Text,BoxApellidoP.Text,BoxApellidoM.Text);
                BoxNombre.Clear();
                BoxApellidoP.Clear();
                BoxApellidoM.Clear();
            }
            
        }

        private void BoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                if (BoxNombre.Text == "" | BoxApellidoP.Text == "" | BoxApellidoM.Text == "")
                {
                    MessageBox.Show("Ningun campo puede quedar vacio", "Error en formulario");

                }
                else
                {
                    GridEstudiantes.Rows.Add(BoxNombre.Text, BoxApellidoP.Text, BoxApellidoM.Text);
                    BoxNombre.Clear();
                    BoxApellidoP.Clear();
                    BoxApellidoM.Clear();
                }
            }

        }

        private void BoxApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (BoxNombre.Text == "" | BoxApellidoP.Text == "" | BoxApellidoM.Text == "")
                {
                    MessageBox.Show("Ningun campo puede quedar vacio", "Error en formulario");

                }
                else
                {
                    GridEstudiantes.Rows.Add(BoxNombre.Text, BoxApellidoP.Text, BoxApellidoM.Text);
                    BoxNombre.Clear();
                    BoxApellidoP.Clear();
                    BoxApellidoM.Clear();
                }
            }

        }

        private void BoxApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (BoxNombre.Text == "" | BoxApellidoP.Text == "" | BoxApellidoM.Text == "")
                {
                    MessageBox.Show("Ningun campo puede quedar vacio", "Error en formulario");

                }
                else
                {
                    GridEstudiantes.Rows.Add(BoxNombre.Text, BoxApellidoP.Text, BoxApellidoM.Text);
                    BoxNombre.Clear();
                    BoxApellidoP.Clear();
                    BoxApellidoM.Clear();
                }

            }

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            GridEstudiantes.Rows.Clear();
        }
    }
}
