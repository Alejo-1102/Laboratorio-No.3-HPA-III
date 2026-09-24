using System;

namespace CasoJuegoCraps
{
    public class Craps
    {
        // Generador de números aleatorios
        private Random numerosAleatorios = new Random();

        // Enumeración con constantes que representan tiros clave
        private enum NombreDados
        {
            DOS_UNO = 2,
            TRES = 3,
            SIETE = 7,
            ONCE = 11,
            DOCE = 12
        }

        // Enumeración para el estado del juego
        private enum Estado
        {
            CONTINUA,
            GANA,
            PIERDE
        }

        // Ejecuta la partida de Craps
        public void Jugar()
        {
            Estado estadoJuego = Estado.CONTINUA;

            int miPunto = 0; // Punto acumulado si no se gana/pierde en el primer tiro
            int sumaDeDados = LanzarDados(); // Primer tiro

            // Determina el estado según la primera tirada
            switch ((NombreDados)sumaDeDados)
            {
                case NombreDados.SIETE:
                case NombreDados.ONCE:
                    estadoJuego = Estado.GANA;
                    break;

                case NombreDados.DOS_UNO:
                case NombreDados.TRES:
                case NombreDados.DOCE:
                    estadoJuego = Estado.PIERDE;
                    break;

                default: // No ganó ni perdió en la primera ronda, establece el punto
                    estadoJuego = Estado.CONTINUA;
                    miPunto = sumaDeDados;
                    Console.WriteLine($"El punto es {miPunto}");
                    break;
            }

            // Bucle secundario si el juego continúa
            while (estadoJuego == Estado.CONTINUA)
            {
                sumaDeDados = LanzarDados();

                if (sumaDeDados == miPunto) // Gana al igualar el punto
                {
                    estadoJuego = Estado.GANA;
                }
                else if (sumaDeDados == (int)NombreDados.SIETE) // Pierde si saca 7 antes del punto
                {
                    estadoJuego = Estado.PIERDE;
                }
            }

            // Mensaje final
            if (estadoJuego == Estado.GANA)
            {
                Console.WriteLine("El jugador gana");
            }
            else
            {
                Console.WriteLine("El jugador pierde");
            }
        }

        // Simula el lanzamiento de dos dados de 6 caras
        public int LanzarDados()
        {
            int dado1 = numerosAleatorios.Next(1, 7);
            int dado2 = numerosAleatorios.Next(1, 7);

            int suma = dado1 + dado2;

            Console.WriteLine($"El jugador lanzó {dado1} + {dado2} = {suma}");

            return suma;
        }
    }
}
