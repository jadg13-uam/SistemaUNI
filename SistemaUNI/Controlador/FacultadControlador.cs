using SistemaUNI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUNI.Controlador
{
    public class FacultadControlador
    {
        private List<Facultad> listaFac = new List<Facultad>();

        public Boolean Agregar(string nombre, string codigo) { 
            Boolean resultado = false;

            try
            {
                Facultad facultad = new Facultad();
                facultad.Nombre = nombre;
                facultad.Codigo = codigo;
                listaFac.Add(facultad);
                resultado = true;
            }catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public List<Facultad> GetFacultades()
        {
            return listaFac;
        }
    }
}
