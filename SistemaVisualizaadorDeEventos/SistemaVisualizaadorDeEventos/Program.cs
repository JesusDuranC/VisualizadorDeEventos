using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizaadorDeEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            LecturaDelTXT lecturaDelTXT = new LecturaDelTXT();
            DivisorDeFechasDelTXT ObtenerFechaDeLosEventos = new DivisorDeFechasDelTXT();
            DivisorDeNombresDelTXT ObtenerNombreDeLosEventos = new DivisorDeNombresDelTXT();
            ConvertirFechasADateTime convertirFechasADateTime = new ConvertirFechasADateTime();  

            string[] Fechas = ObtenerFechaDeLosEventos.ObtenerNomenclaturaDeFechas(lecturaDelTXT.LeerTXT("Eventos.txt"));
            string[] Nombres = ObtenerNombreDeLosEventos.ObtenerNomenclaturaDeNombres(lecturaDelTXT.LeerTXT("Eventos.txt"));
            DateTime[] FechasEnNomenclaturaDateTime = convertirFechasADateTime.ConvertidorADataTime(Nombres, Fechas);

            Console.ReadKey();
        }
    }
}