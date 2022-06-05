using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases.entidades
{
    internal class MdJuegos
    {
            public int idJuego { get; set; }
            public string? Numero_Serie { get; set; }
            public string? Nombre { get; set; }
            public string? Fecha_Estreno { get; set; }
            public string? Precio { get; set; }
            public string? Plataformas { get; set; }
            public string? Edad { get; set; }


        public override string ToString()
            {
                return $"idJuego:{idJuego} Nombre:{Nombre} Fecha_Estreno:{Fecha_Estreno} Precio:{Precio} Plataformas:{Plataformas} Edad:{Edad}";
            }


        }
    }

