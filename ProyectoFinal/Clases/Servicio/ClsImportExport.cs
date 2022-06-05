using ProyectoFinal.Clases.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases.Servicio
{
    internal class ClsImportExport
    {
        private ClsConexion cone;

        public ClsImportExport()
        {
            cone = new();
        }


        public string importar(string archivo)
        {
            string texto = "";
            try
            {
                texto = File.ReadAllText(archivo);
                return $"Procesados:{cone.EjecutarSQLDirecto(texto)}";
            }
            catch (Exception ex)
            {
                return $"Hubo un error al importar {ex.Message}";
            }
        }


        public string exportar(string instruccion, string archivoDestino)
        {
            string textoSalida = "";
            DataTable respuesta = cone.consultaTablaDirecta(instruccion);


            foreach (DataRow dr in respuesta.Rows)
            {
                textoSalida += $"{dr["idJuego"]}{dr["Numero_Serie"]};{dr["Nombre"]};{dr["Fecha_Estreno"]};{dr["Precio"]};{dr["Plataformas"]}\n";
            }


            if (!string.IsNullOrEmpty(textoSalida))
            {
                try
                {
                    File.WriteAllText(archivoDestino, textoSalida);
                    return $"Procesado o creado archivo {archivoDestino}";
                }
                catch (Exception ex)
                {
                    return $"hay clavo en el arhcivo {ex.Message}";
                }
            }

            return "no se encontraron registros";

        }

    }
}

