using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizaadorDeEventos
{
    internal class DivisorDeFechasDelTXT
    {
        public string[] ObtenerNomenclaturaDeFechas(string[] ValoresDelTXT)
        {
            string[] Fechas = new string[ValoresDelTXT.Length];
            for (int i = 0; i < ValoresDelTXT.Length; i++)
            {

                if (ValoresDelTXT[i] != null)
                {
                    Fechas[i] = ConversionDeCadenaDelTXT(ValoresDelTXT[i]);
                    
                }
                else
                {
                    return Fechas;
                }
            }
            return Fechas;
        }

        private string ConversionDeCadenaDelTXT(string EntradaCadena)
        {
            string cadena = "";
            string[] CadenaDividida;
            CadenaDividida = EntradaCadena.Split(',');
            cadena = CadenaDividida[1].ToString();

            return cadena;
        }
    }
}
