using SistemaUNI.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUNI.Vista
{
    public partial class FrmRegistro : Form
    {
        FacultadControlador facultades = new FacultadControlador();
        CarreraControlador carreras = new CarreraControlador();

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void btnAgregarFac_Click(object sender, EventArgs e)
        {
           if( facultades.Agregar(tbNombreFac.Text, tbCodigoFac.Text))
            {
                MessageBox.Show("Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information );
                treeView1.Nodes.Add(tbNombreFac.Text);
                treeView1.ExpandAll();
            }
            else
            {
                MessageBox.Show("Error al guardar.", "Guarda", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void btnAgregaCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                if (carreras.Agregar(tbNombreCarrera.Text, tbCodigoCarrera.Text,
                   Double.Parse(tbPrecioCarrera.Text)))
                {
                    MessageBox.Show("Registro guardado.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }catch(FormatException )
            {
                MessageBox.Show("Verifique el dato en el precio, debe ser un número.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception ex) {
                MessageBox.Show("Ocurrio este error "+  ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
            }
            finally
            {
                LlenarCarreras();
            }

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            LlenarCarreras();
        }

        private void LlenarCarreras()
        {
           lbCarreras.Items.Clear();
            for(int i = 0; i < carreras.GetCarreras().Count; i++)
            {
                lbCarreras.Items.Add(carreras.GetCarreras()[i].Nombre);
            }
        }

      

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                if (lbCarreras.Items.Count > 0)
                {
                    var carrera = lbCarreras.SelectedItems[0];
                    treeView1.SelectedNode.Nodes.Add(carrera.ToString());
                    treeView1.ExpandAll();
                    lbCarreras.Items.Remove(carrera);
                }
                    
            }
        }
    }
}
