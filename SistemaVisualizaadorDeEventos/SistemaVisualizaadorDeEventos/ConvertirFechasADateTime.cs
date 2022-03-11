using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVisualizaadorDeEventos
{
    internal class ConvertirFechasADateTime
    {
        int[] valor = new int[200];
        double[] valor2 = new double[200];
        public DateTime[] ConvertidorADataTime(string[] nombreseventos, string[] FechasEnString)
        {
            

            DateTime[] Fechas = new DateTime[FechasEnString.Length];
            string[] nomevent = nombreseventos;

            for (int i = 0; i < FechasEnString.Length; i++)
            {
                if (FechasEnString[i] != null)
                {


                    Fechas[i] = NomenclaturaDeFechaEnDataTime(FechasEnString[i]);

                    if (Fechas[i] < DateTime.Now)
                    {

                        valor2[i] = Fechas[i].Subtract(DateTime.Now).TotalMinutes;
                        valor2[i] = Math.Abs(valor2[i]);
                        if (valor2[i] < 60) { Console.WriteLine("El evento " + nomevent[i] + " ha ocurrido hace " + Convert.ToInt32(valor2[i]) + " minutos."); }
                        else
                        {
                            valor2[i] = valor2[i] / 60;
                            if (valor2[i] >= 24)
                            {

                                valor[i] = Fechas[i].Subtract(DateTime.Now).Days;

                                valor[i] = Math.Abs(valor[i]);

                                if (valor[i] < 30)
                                {
                                    Console.WriteLine("El evento " + nomevent[i] + " ha ocurrido hace " + valor[i] + " días.");
                                }
                                else
                                {
                                    valor[i] = valor[i] / 30;

                                    if (valor[i] < 12)
                                    {
                                        Console.WriteLine("El evento " + nomevent[i] + " ha ocurrido hace " + valor[i] + " meses.");
                                    }
                                    else
                                    {
                                        valor[i] = valor[i] / 12;
                                        Console.WriteLine("El evento " + nomevent[i] + " ha ocurrido hace " + valor[i] + " años.");
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("El evento " + nomevent[i] + " ha ocurrido hace " + Convert.ToInt32(valor2[i]) + " horas.");
                            }
                        }


                    }

                    else
                    {
                        valor2[i] = Fechas[i].Subtract(DateTime.Now).TotalMinutes;
                        if (valor2[i] < 60) { Console.WriteLine("El evento " + nomevent[i] + " ocurrira en " + Convert.ToInt32(valor2[i]) + " minutos."); }
                        else
                        {
                            valor2[i] = valor2[i] / 60;
                            if (valor2[i] >= 24)
                            {
                                valor[i] = Fechas[i].Subtract(DateTime.Now).Days;
                            if (valor[i] < 30)
                            {
                                Console.WriteLine("El evento " + nomevent[i] + " ocurrirá en " + valor[i] + " días.");
                            }
                            else
                            {
                                valor[i] = valor[i] / 30;

                                if (valor[i] < 12)
                                {
                                    Console.WriteLine("El evento " + nomevent[i] + " ocurrirá en " + valor[i] + " meses.");
                                }
                                else
                                {
                                    valor[i] = valor[i] / 12;
                                    Console.WriteLine("El evento " + nomevent[i] + " ocurrirá en " + valor[i] + " años.");
                                }
                            }
                        }
                            else
                            {
                                Console.WriteLine("El evento " + nomevent[i] + " ocurrirá en " + Convert.ToInt32( valor2[i]) + " horas.");
                            }
                    }
                    }

                }
                

            }
           
            return Fechas;
        }
        public DateTime NomenclaturaDeFechaEnDataTime(string stringFecha)
        {
            DateTime fechasDT = DateTime.Now;
            try
            {
                fechasDT = DateTime.ParseExact(stringFecha, "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Nomenclatura de fecha incorrecta por favor intruduzca la fecha nuevamente en formato: DD/MM/YYYY HH:MM ");
            }
            return fechasDT;

        }
    }
}
