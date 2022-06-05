using ProyectoFinal.Clases.CapaDatos;
using ProyectoFinal.Clases.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases.Servicio
{
    internal class ServicioVideojuego
    {
        ClsConexion cone = new ClsConexion();


        public void lee(string instruccion)
        {

            DataTable respuesta = cone.consultaTablaDirecta(instruccion);

            foreach (DataRow dr in respuesta.Rows)
            {
                Console.WriteLine($"Numero_Serie={dr["Numero_Serie"]} Nombre={dr["Nombre"]} Fecha_Estreno {dr["Fecha_Estreno"]}  Precio={dr["Precio"]}  Plataformas {dr["Plataformas"]} Edad={dr["Edad"]}");
            }

        }




        public DataTable ConsultaSQL(string instruccion)
        {
            DataTable respuesta = cone.consultaTablaDirecta(instruccion);
            return respuesta;
        }

        public int CrearJuego(MdJuegos games)
        {
            string instruccion = $"insert into tbgames (Numero_Serie,Nombre,Fecha_Estreno,Precio,Plataformas,Edad) values('{games.Numero_Serie}','{games.Nombre}','{games.Fecha_Estreno}','{games.Precio}','{games.Plataformas}','{games.Edad}')";
            return cone.EjecutarSQLDirecto(instruccion);
        }


        public MdJuegos ObtenerJuegos(string Numero_Serie)
        {

            MdJuegos alu = new MdJuegos();

            DataTable resp = cone.consultaTablaDirecta($"select * from tbgames where Numero_Serie ='{Numero_Serie}'");
            if (resp.Rows.Count > 0)
            {
                foreach (DataRow item in resp.Rows)
                {
                    alu.idJuego = Convert.ToInt32(item["idJuego"]);
                    alu.Numero_Serie = item["Numero_Serie"].ToString();
                    alu.Nombre = item["Nombre"].ToString();
                    alu.Fecha_Estreno = item["Fecha_Estreno"].ToString();
                    alu.Precio = item["Precio"].ToString();
                    alu.Plataformas = item["Plataformas"].ToString();
                    alu.Edad = item["Edad"].ToString();
                }
                return alu;
            }
            else
            {
                return null;
            }
        }



        public int actualizarJuego(MdJuegos alu)
        {
            string instruccion = $"update tbgames set Numero_Serie = '{alu.Numero_Serie}',Nombre = '{alu.Nombre}',Fecha_Estreno = '{alu.Fecha_Estreno}',Precio= '{alu.Precio}',Plataformas='{alu.Plataformas}',Edad='{alu.Edad}'where Numero_Serie='{alu.Numero_Serie}'";
            return cone.EjecutarSQLDirecto(instruccion);
        }

        public int eliminarJuego(MdJuegos alu)
        {
            string instruccion = $"Delete from tbgames where Numero_Serie='{alu.Numero_Serie}'";
            return cone.EjecutarSQLDirecto(instruccion);
        }

    }
}

 