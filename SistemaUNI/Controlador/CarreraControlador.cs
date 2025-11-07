using Newtonsoft.Json;
using SistemaUNI.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUNI.Controlador
{
    public class CarreraControlador
    {
        private List<Carrera> listaCarrera = new List<Carrera>();

        public Boolean Agregar(string nombre, string codigo, double precio)
        {
            Boolean resultado = false;

            try
            {
                Carrera Carrera = new Carrera();
                Carrera.Nombre = nombre;
                Carrera.Codigo = codigo;
                Carrera.Precio = precio;
                listaCarrera.Add(Carrera);
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            return resultado;
        }

        public List<Carrera> GetCarreras()
        {
            return listaCarrera;
        }

        // Guarda el listado completo en un archivo JSON (UTF-8)
        public bool GuardarJson(string rutaArchivo)
        {
            try
            {
                var json = JsonConvert.SerializeObject(listaCarrera, Formatting.Indented);
                File.WriteAllText(rutaArchivo, json, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Carga el listado desde un archivo JSON (si no existe, deja la lista vacía)
        public List<Carrera> CargarJson(string rutaArchivo)
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    listaCarrera = new List<Carrera>();
                    return listaCarrera;
                }

                var json = File.ReadAllText(rutaArchivo, Encoding.UTF8);
                listaCarrera = JsonConvert.DeserializeObject<List<Carrera>>(json) ?? new List<Carrera>();
                return listaCarrera;
            }
            catch
            {
                // Puede registrar el error aquí si lo desea.
                listaCarrera = new List<Carrera>();
                return listaCarrera;
            }
        }


    }
}
