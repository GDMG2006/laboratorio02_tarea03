using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_02_tarea_03
{
    internal class Program
        {
            static string[,] Encuesta = new string[8, 8];
            static int indice = 0;
        static int indices = 0;
        static void Main()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Sistema de Encuestas ---");
                    Console.WriteLine("1. Encuesta");
                    Console.WriteLine("2. Pregunta  de Encuesta");
                    Console.WriteLine("3. Repuesta de Encuesta");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opción: ");
               

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarEncuesta();
                                break;
                            case 2:
                                VisualizarEncuestas();
                                break;
                            case 3:
                                ImprimirPregunta();
                                break;
                            case 4:
                                Console.WriteLine("Saliendo del sistema...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida, intente de nuevo.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida, por favor ingrese un número.");
                    }
                } while (opcion != 4);
            }

          

            static void AgregarEncuesta()
            {
            if (indice < Encuesta.GetLength(0))

            {
                    
                int i= 0;
                i++;
                Console.WriteLine("\n------ Repuestas ------");
                Console.WriteLine("1. Nombre de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 0] = Console.ReadLine();
                Console.WriteLine("2. Codigo de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 1] = Console.ReadLine();
                Console.WriteLine("3. Proposito de la encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 2] = Console.ReadLine();
                Console.WriteLine("4. Fecha de inicio de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 3] = Console.ReadLine();
                Console.WriteLine("5. Fecha final de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 4] = Console.ReadLine();
                Console.WriteLine("6. Tamaño de la muestra?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 5] = Console.ReadLine();
                Console.WriteLine("7. Formato de preguntas?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indice, 6] = Console.ReadLine();
               

                Console.WriteLine("\n Pregunta agregada correctamente.");
                    indice++;
                }
                else
                {
                    Console.WriteLine("No se pueden agregar más preguntas, la matriz está llena.");
                }
            }

            static void VisualizarEncuestas()
            { 
            const int maxPreguntas = 7;
            if (indice == 0)
                {
                    Console.WriteLine("\n No hay preguntas registradas.");
                    return;
            }

            Console.WriteLine("\n--- Preguntas---");
            Console.WriteLine("Ingrese las preguntas agregar a la encuesta");
            for (int i = 0; i < indice; i++)
            { 
                Console.WriteLine("Ingrese la pregunta 1:");
                Encuesta[indice, 0] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 2:");
                Encuesta[indice , 1] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 3:" );
                Encuesta[indice, 2] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 4:" );
                Encuesta[indice, 3] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 5:" );
                Encuesta[indice, 4] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 6:" );
                Encuesta[indice, 5] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 7:" );
                Encuesta[indice, 6] = Console.ReadLine();
            }
            }       

            static void ImprimirPregunta()
            {
               
            if (indice == 0)
            {
                Console.WriteLine("\n No hay preguntas registradas.");
                return;
            }
            Console.Write("\n---- Respuestas ----");
            for (int i = 0; i < indice; i++)
            {
                Console.WriteLine($"\n{Encuesta[indice,0]}");
                Encuesta[indices, 0] = Console.ReadLine();
                Console.WriteLine($"{Encuesta[indice, 1]}");
                Encuesta[indices, 1] = Console.ReadLine();
                Console.WriteLine($"{Encuesta[indice, 2]}");
                Encuesta[indices, 2] = Console.ReadLine();
                Console.WriteLine($"{Encuesta[indice, 3]}");
                Encuesta[indices, 3] = Console.ReadLine();
                Console.WriteLine($"{Encuesta[indice, 4]}");
                Encuesta[indices, 4] = Console.ReadLine();
                Console.WriteLine($"{Encuesta[indice, 5]}");
                Encuesta[indices, 5] = Console.ReadLine();
                Console.WriteLine($"{Encuesta[indice, 6]}");
                Encuesta[indices, 6] = Console.ReadLine();
            }
                }

        }
    }


