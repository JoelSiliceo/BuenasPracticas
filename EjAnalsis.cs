using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project1
{
    class EjAnalsis
    {
        public static void Main(string[] args)
        {
            List<Evento> lsEventos = new List<Evento>();
            string[] Lineas = null;
            try
            {
                 Lineas = System.IO.File.ReadAllLines(args[0]);
            }
            catch
            {
                Console.WriteLine("Error al cargar el archivo");
            }

            try
            {
                CargaSeparador cargador = new CargaSeparador(',');
                lsEventos = cargador.Cargador(Lineas.ToList()); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Revisador rev = new Revisador();

            foreach(Evento evt1 in lsEventos)
            {
                Console.WriteLine(String.Format("{0} {1} ",evt1.Descripcion,  rev.RevisaFechas(evt1)));
            }

            Console.ReadKey();
        }

        public class Revisador
        {
            public string RevisaFechas(Evento evento)
            {
                string salida = string.Empty;
                Differencia dif = new Differencia();
                dif.Minutos = Math.Abs((DateTime.Now - evento.Fecha).Minutes);
                dif.Horas = Math.Abs((DateTime.Now - evento.Fecha).Hours);
                dif.Dias = Math.Abs((DateTime.Now - evento.Fecha).Days);
                dif.Meses = Math.Abs((DateTime.Now - evento.Fecha).Days / 30);
                
                if (evento.Fecha < DateTime.Now)
                {
                    salida = String.Format("ocurrió hace {0}" , dif.Resultado());
                }
                else
                {
                    salida = String.Format("ocurrirá en {0}", dif.Resultado());
                }
                
                return salida;
            }
        }

        public class Differencia
        {
            public int Meses { get; set; }
            public int Dias { get; set; }

            public int Horas { get; set; }

            public int Minutos { get; set; }

            public string Resultado()
            {
                string differencia = string.Empty;
                if (Meses > 0)
                {
                    differencia = string.Format("{0} meses" , Meses);
                }
                else if (Dias > 0)
                {
                    differencia = string.Format("{0} dias" , Dias);
                }
                else if (Horas > 0)
                {
                    differencia = string.Format("{0} horas" , Horas);
                }
                else if (Minutos > 0)
                {
                    differencia = string.Format("{0} minutos" , Minutos);
                }

                return differencia;
            }
        }

        public class CargaSeparador 
        {
            private char Separador { get; set; }

            public CargaSeparador(char separador)
            {
                this.Separador = separador;
            }
                       
            public List<Evento> Cargador(List<string> lineas)
            {
                List<Evento> lsEventos = new List<Evento>();
                try
                {
                    foreach (string linea in lineas)
                    {
                        Evento evt = new Evento();
                        evt.Descripcion = linea.Split(this.Separador)[0];
                        evt.Fecha = Convert.ToDateTime(linea.Split(this.Separador)[1]);
                        lsEventos.Add(evt);
                    }
                }
                catch
                {
                    throw new Exception("Error al cargar los datos");
                }

                return lsEventos;
            }

        }

        public class Evento
        {

            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
        }
    }
}
