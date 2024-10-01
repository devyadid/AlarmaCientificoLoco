using System;

namespace AlarmaCientificoLoco
{
    class Program
    {
        // Nombre del estudiante: Yadid Mayerly Acero Osorio
        // Grupo: 213022_377
        // Programa: Ingeniería de Sistemas
        // Código Fuente: autoría propia

        static void Main(string[] args)
        {
            // Solicitar la presión
            Console.Write("Ingrese la presión en libras: ");
            double presion = Convert.ToDouble(Console.ReadLine());

            // Solicitar la temperatura
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            // Verificar condiciones para encender o apagar la alarma
            if (presion >= 35 || (temperatura >= 75 && temperatura < 95))
            {
                Console.WriteLine("Alarma encendida");
            }
            else
            {
                Console.WriteLine("Alarma apagada");
            }
        }
    }
}
