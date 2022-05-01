using System;
namespace Switch
{
    class Program
    {


        //Variable Global Entera
        static int Entero;

        /*Generación de la Tabla de Multiplicar del Número Entero
        con multiplicaciones comprendidas del 1 al 12 */
        static void ProcedimientoTablaMultiplicar(int x) {
            if (x >= 0)
            {
                Console.WriteLine("La tabla de Multiplicacion de " + Entero, " es:");
                Console.WriteLine("" + "\n");
                for (int i = 1; i <= 12; i++)
                {
                    int res = x * i;
                    Console.WriteLine(x + " * " + i + " = " + res);
                }

            }
            else
            {
                Console.WriteLine("Tienes que asignar un valor entero y positivo en la Opcion 1 para hacer la tabla");
            }
        }
        // Comprueba si Entero es primo o si no lo es, e imprime su resultado

        static void ProcedimientoMostrarEvaluacionPrimo(int x) {
            if (Entero % 2 == 0) {
                Console.WriteLine(x + " es un numero primo");
            }
            else {
                Console.WriteLine(x + " no es un numero primo");
            }
        }
        // DARK NIGHTS ARE UPON US. PREPARE YOU WILL HEAR THE CHORUS

        static void ProcedimientoDiagonalesMatriz()
        {
            int[,] numero;
            numero = new int[4, 4];
            int fila;
            int col;

            //Lectura de Matriz
            for (fila = 0; fila < 4; fila++)
            {
                for (col = 0; col < 4; col++)
                {
                    Console.WriteLine("Ingrese un numero para la posicion " + fila + col);
                    numero[fila, col] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();

            //Escritura de Matriz
            Console.WriteLine("Dada la matriz " + "\n");
            for (fila = 0; fila < 4; fila++)
            {
                for (col = 0; col < 4; col++) { 

                    Console.Write(" " + numero[fila, col]);
                }
                Console.WriteLine();
            }
            

            //Diagonal Principal
            //for (int i = 0; i < 4; fila++)
          //  {
              //  Console.WriteLine("Los valores de la diagonal principal son " + numero[i, i]);
            //}
            //Diagonal Secundaria
            //for (int i = 0; fila < 4; fila++) 
           // {
             //   for (int j = 4; j <= 0; i--)
               // {
                //    Console.WriteLine("Los valores de la diagonal secundaria " + numero[i, j]);
               // }
           // }
           




        }

            public static void Main(string[] args)
            {
                int indice = 0;
                while (indice != 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WindowWidth = 100;
                    Console.WindowHeight = 20;
                    Console.WriteLine("\n" + "\n" + "Menu Principal");
                    Console.WriteLine("------------------" + "\n");
                    Console.WriteLine("1 - Capturar Valor ");
                    Console.WriteLine("2 - Generar Tabla de Multiplicar");
                    Console.WriteLine("3 - Determinar Si es Primo o No Primo");
                    Console.WriteLine("4 - Capturar e imprimir una Matriz 4 x 4 ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("5 - Salir del programa");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + "------------------");


                    Console.WriteLine("Digite el numero de la operacion a realizar");
                    indice = Convert.ToInt16(Console.ReadLine());
                    //Convertir el texto (String) a tipo Int



                    switch (indice)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese un numero entero");
                                Entero = Convert.ToInt16(Console.ReadLine()); //Guardamos Entero en Variable Global.
                                Console.WriteLine("Se ha guardado el valor~~");
                                Console.ReadKey();
                                Console.Clear();
                                break;       //Volver al menu, ¿Como era?.... Ah si cierto, es un While xd.
                            }
                        case 2:
                            {
                                Console.Clear();
                                ProcedimientoTablaMultiplicar(Entero);  //Invocamos procedimiento para Multiplicar.
                                Console.ReadKey();
                                Console.Clear(); break;
                            }

                        case 3:
                            {
                                Console.Clear();
                                ProcedimientoMostrarEvaluacionPrimo(Entero); //Invocamos procedimiento para comprobar si es primo o no
                                Console.ReadKey();
                                Console.Clear(); break;
                            }

                        case 4:
                            {
                                Console.Clear();
                                ProcedimientoDiagonalesMatriz(); //Wea rara de matriz. Aun asi, fue divertido hacerla :)
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                Console.WriteLine("Fin del Programa");  //Tan-Tan!
                                break;
                            }
                        case 6:
                            Console.Clear();
                            Console.Clear();
                            break;
                        default:
                            {
                                Console.WriteLine("Esa no es una operación valida");
                                Console.ReadKey();
                                Console.Clear(); break;
                            }
                    }
                }
            }


        }
    }

