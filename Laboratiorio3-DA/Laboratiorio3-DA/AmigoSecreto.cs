using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratiorio3_DA
{
    internal class AmigoSecreto
    {
        public int CantidadJugadores { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int NumeroEndulzadas { get; set; }
        public int FrecuenciaEndulzadasDias { get; set; }
        public decimal ValorEndulzada { get; set; }
        public decimal ValorRegalo { get; set; }
        public Jugador[] Jugadores { get; private set; }

        public AmigoSecreto(int cantidadJugadores)
        {
            if (cantidadJugadores <= 1)
            {
                throw new ArgumentException("Se requieren al menos dos jugadores para el juego de Amigo Secreto.");
            }

            CantidadJugadores = cantidadJugadores;
            Jugadores = new Jugador[cantidadJugadores];
        }

        public void AsignarJugadores(Jugador[] jugadores)
        {
            if (jugadores.Length != CantidadJugadores)
            {
                throw new Exception("La cantidad de jugadores proporcionados no coincide con la cantidad establecida.");
            }

            if (jugadores.Distinct().Count() != jugadores.Length)
            {
                throw new Exception("No deben existir jugadores duplicados.");
            }

            Jugadores = jugadores;
        }

        public void AsignarAmigosSecretos()
        {
            Random rnd = new Random();
            Jugador[] jugadoresOriginales = Jugadores;
            Jugador[] jugadoresBarajados = (Jugador[])jugadoresOriginales.Clone();
            bool todosDiferentes = false;

            while (!todosDiferentes)
            {
                todosDiferentes = true;

                // Barajamos el vector
                for (int i = jugadoresBarajados.Length - 1; i > 0; i--)
                {
                    int j = rnd.Next(i + 1);
                    Jugador temp = jugadoresBarajados[i];
                    jugadoresBarajados[i] = jugadoresBarajados[j];
                    jugadoresBarajados[j] = temp;
                }

                // Comprobar que nadie sea su propio amigo secreto
                for (int i = 0; i < jugadoresOriginales.Length; i++)
                {
                    if (jugadoresOriginales[i] == jugadoresBarajados[i])
                    {
                        todosDiferentes = false;
                        break;
                    }
                }
            }

            // Asigna los amigos secretos a cada jugador
            for (int i = 0; i < jugadoresOriginales.Length; i++)
            {
                jugadoresOriginales[i].AmigoSecreto = jugadoresBarajados[i];
            }
        }



        public void ImprimirInformacionJuego()
        {
            Console.WriteLine("Información del Juego de Amigo Secreto:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Fecha de Inicio: {FechaInicio:dd/MM/yyyy}");
            Console.WriteLine($"Fecha de Fin: {FechaFin:dd/MM/yyyy}");
            Console.WriteLine($"Número de Endulzadas: {NumeroEndulzadas}");
            Console.WriteLine($"Frecuencia de Endulzadas (en días): {FrecuenciaEndulzadasDias}");
            Console.WriteLine($"Valor de la Endulzada: {ValorEndulzada:C2}");
            Console.WriteLine($"Valor del Regalo: {ValorRegalo:C2}");
            Console.WriteLine("---------------------------------------");
        }


        public void ImprimirGustosJugadores()
        {
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.mostrarJugador());
            }
        }

        public int CalcularDiasProximaEndulzada(DateTime fechaActual)
        {
            if (fechaActual < FechaInicio)
            {
                throw new Exception("La fecha actual proporcionada es anterior a la fecha de inicio del juego.");
            }

            // Calculamos cuántos días han pasado desde la FechaInicio hasta la fechaActual
            int diasDesdeInicio = (fechaActual - FechaInicio).Days;

            // Si no ha pasado el tiempo para una sola endulzada, devolvemos la diferencia.
            if (diasDesdeInicio < FrecuenciaEndulzadasDias)
            {
                return FrecuenciaEndulzadasDias - diasDesdeInicio;
            }

            // Si ya ha pasado el tiempo para la última endulzada, devolvemos 0.
            if (diasDesdeInicio >= FrecuenciaEndulzadasDias * NumeroEndulzadas)
            {
                return 0;
            }

            // Calculamos cuántos días han pasado desde la última endulzada
            int diasDesdeUltimaEndulzada = diasDesdeInicio % FrecuenciaEndulzadasDias;

            // Devolvemos los días que faltan para la próxima endulzada.
            return FrecuenciaEndulzadasDias - diasDesdeUltimaEndulzada;
        }

    }
}

            
