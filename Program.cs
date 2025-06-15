using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    
        internal class Program
        {
            // Matrices ya existentes (tu compañero)
            static string[,] Encuesta = new string[8, 8]; // Ejemplo tamaño
            static int indiceEncuesta = 0;

            static string[,] Pregunta = new string[8, 8];
            static int indicePregunta = 0;

            static string[,] Respuesta = new string[8, 8];
            static int indiceRespuesta = 0;

            // Nuevas matrices
            static string[,] Productos = new string[5, 7];
            static int indiceProductos = 0;

            static string[,] Estudiantes = new string[5, 7];
            static int indiceEstudiantes = 0;

            static void Main()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú Principal ---");
                    Console.WriteLine("1. Gestionar Encuesta");
                    Console.WriteLine("2. Gestionar Preguntas");
                    Console.WriteLine("3. Gestionar Respuestas");
                    Console.WriteLine("4. Gestionar Productos");
                    Console.WriteLine("5. Gestionar Estudiantes");
                    Console.WriteLine("6. Salir");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                GestionarEncuesta();
                                break;
                            case 2:
                                GestionarPregunta();
                                break;
                            case 3:
                                GestionarRespuesta();
                                break;
                            case 4:
                                GestionarProductos();
                                break;
                            case 5:
                                GestionarEstudiantes();
                                break;
                            case 6:
                                Console.WriteLine("Saliendo del programa...");
                                break;
                            default:
                                Console.WriteLine("Opción inválida. Intente nuevamente.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Por favor ingrese un número.");
                    }
                } while (opcion != 6);
            }

            // --- GESTIONAR ENCUESTA ---
            static void GestionarEncuesta()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú Encuesta ---");
                    Console.WriteLine("1. Agregar Encuesta");
                    Console.WriteLine("2. Ver Encuestas");
                    Console.WriteLine("3. Mostrar Encuesta específica");
                    Console.WriteLine("4. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarEncuesta();
                                break;
                            case 2:
                                VerEncuestas();
                                break;
                            case 3:
                                MostrarEncuestaEspecifica();
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                } while (opcion != 4);
        }



        static void AgregarEncuesta()
        {
            if (indiceEncuesta < Encuesta.GetLength(0))

            {

                int i = 0;
                i++;
                Console.WriteLine("\n------ Repuestas ------");
                Console.WriteLine("1. Nombre de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta, 0] = Console.ReadLine();
                Console.WriteLine("2. Codigo de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta, 1] = Console.ReadLine();
                Console.WriteLine("3. Proposito de la encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta, 2] = Console.ReadLine();
                Console.WriteLine("4. Fecha de inicio de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta, 3] = Console.ReadLine();
                Console.WriteLine("5. Fecha final de la Encuesta?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta, 4] = Console.ReadLine();
                Console.WriteLine("6. Tamaño de la muestra?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta, 5] = Console.ReadLine();
                Console.WriteLine("7. Formato de preguntas?");
                Console.WriteLine("Ingrese la respuesta para la pregunta " + i++);
                Encuesta[indiceEncuesta,7] = Console.ReadLine();


                Console.WriteLine("\n Pregunta agregada correctamente.");
                indiceEncuesta++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más preguntas, la matriz está llena.");
            }
        }

        static void VerEncuestas()
            {
                if (indiceEncuesta == 0)
                {
                    Console.WriteLine("No hay encuestas registradas.");
                    return;
                }

                for (int i = 0; i < indiceEncuesta; i++)
                {
                    Console.WriteLine($"\nEncuesta #{i + 1}:");
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine($"Característica {j + 1}: {Encuesta[i, j]}");
                    }
                }
            }

            static void MostrarEncuestaEspecifica()
            {
                Console.Write($"Ingrese el número de encuesta a mostrar (1-{indiceEncuesta}): ");
                if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 1 && pos <= indiceEncuesta)
                {
                    int i = pos - 1;
                    Console.WriteLine($"\nEncuesta #{pos}:");
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine($"Característica {j + 1}: {Encuesta[i, j]}");
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }

            // --- GESTIONAR PREGUNTA ---
            static void GestionarPregunta()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú Preguntas ---");
                    Console.WriteLine("1. Agregar Pregunta");
                    Console.WriteLine("2. Ver Preguntas");
                    Console.WriteLine("3. Mostrar Pregunta específica");
                    Console.WriteLine("4. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                            VisualizarEncuestas();
                                break;
                            case 2:
                                VerPreguntas();
                                break;
                            case 3:
                                MostrarPreguntaEspecifica();
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                } while (opcion != 4);
            }

        static void VisualizarEncuestas()
        {

            

            Console.WriteLine("\n--- Preguntas---");
            Console.WriteLine("Ingrese las preguntas a la encuesta");
            for (int i = 0; i < indiceEncuesta; i++)
            {
                Console.WriteLine("Ingrese la pregunta 1:");
                Encuesta[indicePregunta, 0] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 2:");
                Encuesta[indicePregunta, 1] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 3:");
                Encuesta[indicePregunta, 2] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 4:");
                Encuesta[indicePregunta, 3] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 5:");
                Encuesta[indicePregunta, 4] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 6:");
                Encuesta[indicePregunta, 5] = Console.ReadLine();
                Console.WriteLine("Ingrese la pregunta 7:");
                Encuesta[indicePregunta, 6] = Console.ReadLine();
            }
        }

        static void VerPreguntas()
            {
                if (indicePregunta == 0)
                {
                    Console.WriteLine("No hay preguntas registradas.");
                    return;
                }

                for (int i = 0; i < indicePregunta; i++)
                {
                    Console.WriteLine($"\nPregunta #{i + 1}:");
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine($"Pregunta {j + 1}: {Pregunta[i, j]}");
                    }
                }
            }

            static void MostrarPreguntaEspecifica()
            {
                Console.Write($"Ingrese el número de pregunta a mostrar (1-{indicePregunta}): ");
                if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 1 && pos <= indicePregunta)
                {
                    int i = pos - 1;
                    Console.WriteLine($"\nPregunta #{pos}:");
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine($"Característica {j + 1}: {Pregunta[i, j]}");
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }

            // --- GESTIONAR RESPUESTA ---
            static void GestionarRespuesta()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú Respuestas ---");
                    Console.WriteLine("1. Agregar Respuesta");
                    Console.WriteLine("2. Ver Respuestas");
                    Console.WriteLine("3. Mostrar Respuesta específica");
                    Console.WriteLine("4. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarRespuesta();
                                break;
                            case 2:
                                VerRespuestas();
                                break;
                            case 3:
                                MostrarRespuestaEspecifica();
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                } while (opcion != 4);
            }

        static void AgregarRespuesta()
        {
            if (indiceEncuesta == 0)
            {
                Console.WriteLine("\nNo hay preguntas registradas.");
                return;
            }

            Console.WriteLine("\n---- Respuestas ----");

            for (int i = 0; i < indiceEncuesta; i++)
            {
                for (int j = 0; j < 7; j++) // Suponiendo que hay 7 preguntas por encuesta
                {
                    Console.WriteLine($"{Encuesta[i, j]}"); // Muestra la pregunta al usuario
                    Console.Write("Ingrese su respuesta: ");
                    Respuesta[i, j] = Console.ReadLine();
                }
            }

            // Incrementar el índice de respuesta
            indiceRespuesta++;
        }

        static void VerRespuestas()
        {
            if (indiceRespuesta == 0)
            {
                Console.WriteLine("No hay respuestas registradas.");
                return;
            }

            for (int i = 0; i < indiceEncuesta; i++) // Muestra respuestas por encuesta
            {
                Console.WriteLine($"\nRespuestas para la encuesta #{i + 1}:");
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Pregunta {j + 1}: {Encuesta[i, j]}");
                    Console.WriteLine($"Respuesta: {Respuesta[i, j]}");
                }
            }
        }
        static void MostrarRespuestaEspecifica()
            {
                Console.Write($"Ingrese el número de respuesta a mostrar (1-{indiceRespuesta}): ");
                if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 1 && pos <= indiceRespuesta)
                {
                    int i = pos - 1;
                    Console.WriteLine($"\nRespuesta #{pos}:");
                    for (int j = 0; j < 7; j++)
                    {
                        Console.WriteLine($"Característica {j + 1}: {Respuesta[i, j]}");
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }

            // --- GESTIONAR PRODUCTOS ---
            static void GestionarProductos()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú Productos ---");
                    Console.WriteLine("1. Agregar Producto");
                    Console.WriteLine("2. Ver Productos");
                    Console.WriteLine("3. Mostrar Producto específico");
                    Console.WriteLine("4. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarProducto();
                                break;
                            case 2:
                                VerProductos();
                                break;
                            case 3:
                                MostrarProductoEspecifico();
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                } while (opcion != 4);
            }

            static void AgregarProducto()
            {
                if (indiceProductos >= Productos.GetLength(0))
                {
                    Console.WriteLine("No se pueden agregar más productos.");
                    return;
                }

                Console.WriteLine("Ingrese los datos del producto:");

                Console.Write("ID: ");
                Productos[indiceProductos, 0] = Console.ReadLine();

                Console.Write("Nombre: ");
                Productos[indiceProductos, 1] = Console.ReadLine();

                Console.Write("Categoría: ");
                Productos[indiceProductos, 2] = Console.ReadLine();

                double precio;
                do
                {
                    Console.Write("Precio: ");
                } while (!double.TryParse(Console.ReadLine(), out precio));
                Productos[indiceProductos, 3] = precio.ToString("F2");

                int stock;
                do
                {
                    Console.Write("Stock: ");
                } while (!int.TryParse(Console.ReadLine(), out stock));
                Productos[indiceProductos, 4] = stock.ToString();

                Console.Write("Proveedor: ");
                Productos[indiceProductos, 5] = Console.ReadLine();

                Console.Write("Fecha de ingreso (dd/mm/aaaa): ");
                Productos[indiceProductos, 6] = Console.ReadLine();

                indiceProductos++;
                Console.WriteLine("Producto agregado correctamente.");
            }

            static void VerProductos()
            {
                if (indiceProductos == 0)
                {
                    Console.WriteLine("No hay productos registrados.");
                    return;
                }

                for (int i = 0; i < indiceProductos; i++)
                {
                    Console.WriteLine($"\nProducto #{i + 1}:");
                    Console.WriteLine($"ID: {Productos[i, 0]}");
                    Console.WriteLine($"Nombre: {Productos[i, 1]}");
                    Console.WriteLine($"Categoría: {Productos[i, 2]}");
                    Console.WriteLine($"Precio: {Productos[i, 3]}");
                    Console.WriteLine($"Stock: {Productos[i, 4]}");
                    Console.WriteLine($"Proveedor: {Productos[i, 5]}");
                    Console.WriteLine($"Fecha de ingreso: {Productos[i, 6]}");
                }
            }

            static void MostrarProductoEspecifico()
            {
                Console.Write($"Ingrese el número de producto a mostrar (1-{indiceProductos}): ");
                if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 1 && pos <= indiceProductos)
                {
                    int i = pos - 1;
                    Console.WriteLine($"\nProducto #{pos}:");
                    Console.WriteLine($"ID: {Productos[i, 0]}");
                    Console.WriteLine($"Nombre: {Productos[i, 1]}");
                    Console.WriteLine($"Categoría: {Productos[i, 2]}");
                    Console.WriteLine($"Precio: {Productos[i, 3]}");
                    Console.WriteLine($"Stock: {Productos[i, 4]}");
                    Console.WriteLine($"Proveedor: {Productos[i, 5]}");
                    Console.WriteLine($"Fecha de ingreso: {Productos[i, 6]}");
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }

            // --- GESTIONAR ESTUDIANTES ---
            static void GestionarEstudiantes()
            {
                int opcion;
                do
                {
                    Console.WriteLine("\n--- Menú Estudiantes ---");
                    Console.WriteLine("1. Agregar Estudiante");
                    Console.WriteLine("2. Ver Estudiantes");
                    Console.WriteLine("3. Mostrar Estudiante específico");
                    Console.WriteLine("4. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarEstudiante();
                                break;
                            case 2:
                                VerEstudiantes();
                                break;
                            case 3:
                                MostrarEstudianteEspecifico();
                                break;
                            case 4:
                                return;
                            default:
                                Console.WriteLine("Opción inválida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                } while (opcion != 4);
            }

            static void AgregarEstudiante()
            {
                if (indiceEstudiantes >= Estudiantes.GetLength(0))
                {
                    Console.WriteLine("No se pueden agregar más estudiantes.");
                    return;
                }

                Console.WriteLine("Ingrese los datos del estudiante:");

                Console.Write("ID: ");
                Estudiantes[indiceEstudiantes, 0] = Console.ReadLine();

                Console.Write("Nombre: ");
                Estudiantes[indiceEstudiantes, 1] = Console.ReadLine();

                int edad;
                do
                {
                    Console.Write("Edad: ");
                } while (!int.TryParse(Console.ReadLine(), out edad));
                Estudiantes[indiceEstudiantes, 2] = edad.ToString();

                Console.Write("Carrera: ");
                Estudiantes[indiceEstudiantes, 3] = Console.ReadLine();

                Console.Write("Correo: ");
                Estudiantes[indiceEstudiantes, 4] = Console.ReadLine();

                Console.Write("Teléfono: ");
                Estudiantes[indiceEstudiantes, 5] = Console.ReadLine();

                double promedio;
                do
                {
                    Console.Write("Promedio: ");
                } while (!double.TryParse(Console.ReadLine(), out promedio));
                Estudiantes[indiceEstudiantes, 6] = promedio.ToString("F2");

                indiceEstudiantes++;
                Console.WriteLine("Estudiante agregado correctamente.");
            }

            static void VerEstudiantes()
            {
                if (indiceEstudiantes == 0)
                {
                    Console.WriteLine("No hay estudiantes registrados.");
                    return;
                }

                for (int i = 0; i < indiceEstudiantes; i++)
                {
                    Console.WriteLine($"\nEstudiante #{i + 1}:");
                    Console.WriteLine($"ID: {Estudiantes[i, 0]}");
                    Console.WriteLine($"Nombre: {Estudiantes[i, 1]}");
                    Console.WriteLine($"Edad: {Estudiantes[i, 2]}");
                    Console.WriteLine($"Carrera: {Estudiantes[i, 3]}");
                    Console.WriteLine($"Correo: {Estudiantes[i, 4]}");
                    Console.WriteLine($"Teléfono: {Estudiantes[i, 5]}");
                    Console.WriteLine($"Promedio: {Estudiantes[i, 6]}");
                }
            }

            static void MostrarEstudianteEspecifico()
            {
                Console.Write($"Ingrese el número de estudiante a mostrar (1-{indiceEstudiantes}): ");
                if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 1 && pos <= indiceEstudiantes)
                {
                    int i = pos - 1;
                    Console.WriteLine($"\nEstudiante #{pos}:");
                    Console.WriteLine($"ID: {Estudiantes[i, 0]}");
                    Console.WriteLine($"Nombre: {Estudiantes[i, 1]}");
                    Console.WriteLine($"Edad: {Estudiantes[i, 2]}");
                    Console.WriteLine($"Carrera: {Estudiantes[i, 3]}");
                    Console.WriteLine($"Correo: {Estudiantes[i, 4]}");
                    Console.WriteLine($"Teléfono: {Estudiantes[i, 5]}");
                    Console.WriteLine($"Promedio: {Estudiantes[i, 6]}");
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
        }
    }

    
