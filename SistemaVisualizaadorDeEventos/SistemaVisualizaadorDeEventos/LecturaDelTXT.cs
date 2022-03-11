using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizaadorDeEventos
{
    internal class LecturaDelTXT
    {
        public string[] LeerTXT(string NombreFichero)
        {
            StreamReader EventosDelTXT = new StreamReader(NombreFichero);
            string[] LienasFichero = new string[LONGTXT(NombreFichero)];
            for (int i = 0; (LienasFichero[i] = EventosDelTXT.ReadLine()) != null; i++) ;
            return LienasFichero;
        }

        private int LONGTXT(string NombreFichero)
        {
            StreamReader EventosenelTXT = new StreamReader(NombreFichero);
            int longitiud = EventosenelTXT.ReadToEnd().Length;

            return longitiud;
        }
    }
}
