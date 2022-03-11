using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizaadorDeEventos
{
    internal class ImprimirEnPantalla
    {
        int[] valor = new int[200];

        ConvertirFechasADateTime obj=new ConvertirFechasADateTime();
        public void imprimirevetnos(string[] nombreevento, DateTime[] Fechasenviadas) {

            string[] nombredeloseventos = nombreevento;
            DateTime[] dateTimeN = Fechasenviadas;

           
                for (int i = 0; i < dateTimeN.Length; i++) {

                    if (dateTimeN[i] < DateTime.Now)
                    {
                        valor[i] = dateTimeN[i].Subtract(DateTime.Now).Days;

                        if (valor[i] < 0)
                        {
                            valor[i] = Math.Abs(valor[i]);

                            if (valor[i] < 30)
                            {
                                Console.WriteLine("El evento ha ocurrido hace " + valor[i] + " días.");
                            }
                            else
                            {
                                valor[i] = valor[i] / 30;

                                if (valor[i] < 12)
                                {
                                    Console.WriteLine("El evento ha ocurrido hace " + valor[i] + " meses.");
                                }
                                else
                                {
                                    valor[i] = valor[i] / 12;
                                    Console.WriteLine("El evento ha ocurrido hace " + valor[i] + " años.");
                                }
                            }
                        }

                    }
                    else
                    {
                        valor[i] = dateTimeN[i].Subtract(DateTime.Now).Days;
                        if (valor[i] < 30)
                        {
                            Console.WriteLine("El evento ocurrirá en " + valor[i] + " días.");
                        }
                        else
                        {
                            valor[i] = valor[i] / 30;

                            if (valor[i] < 12)
                            {
                                Console.WriteLine("El evento ocurrirá en " + valor[i] + " meses.");
                            }
                            else
                            {
                                valor[i] = valor[i] / 12;
                                Console.WriteLine("El evento  ocurrirá en " + valor[i] + " años.");
                            }
                        }

                }
            }
                    
                }
    }
}
