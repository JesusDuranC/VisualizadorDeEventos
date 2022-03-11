using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizaadorDeEventos
{
    internal class DivisorDeNombresDelTXT
    {
        public string[] ObtenerNomenclaturaDeNombres(string[] ValoresDelTXT)
        {
            string[] Nombres = new string[ValoresDelTXT.Length];

            for (int i = 0; i < ValoresDelTXT.Length; i++)
            {

                if (ValoresDelTXT[i] != null)
                {
                    Nombres[i] = ConversionDeCadenaDelTXT(ValoresDelTXT[i]);
                 
                }
                else
                {
                    return Nombres;
                }
            }
            return Nombres;
        }

        private string ConversionDeCadenaDelTXT(string EntradaCadena)
        {
            string cadena = "";
            string[] CadenaDividida;
            CadenaDividida = EntradaCadena.Split(',');
            cadena = CadenaDividida[0].ToString();

            return cadena;
        }
    }
}
