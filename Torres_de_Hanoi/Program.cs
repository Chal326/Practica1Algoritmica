using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = false;
            Console.WriteLine("El gran juego de las Torres de Hanoi.\n");
            Console.WriteLine("3 torres\n");
            Console.WriteLine("Indica el numero de discos...");
            do
            {
                String piezasString = Console.ReadLine();
                int piezas;
                if (Int32.TryParse(piezasString, out piezas))
                {
                    if (piezas <= 0)
                    {
                        Console.WriteLine("No se admiten numeros menores que 0.");
                    }
                    else
                    {
                        Console.WriteLine("\nHas seleccionado " + piezas + " discos\n");
                        Console.WriteLine("Indica I para Iterativo o R para Recursivo...");
                        String metodoString = Console.ReadLine().ToUpper();
                        switch (metodoString)
                        {
                            case "I":
                                Console.WriteLine("\nHas seleccionado el método I\n");
                                Pila iniI = new Pila(piezas);
                                Pila auxI = new Pila();
                                Pila finI = new Pila();

                                int movimientosI = new Hanoi().iterativo(piezas, iniI, finI, auxI);


                                Console.WriteLine("Resuelto en " + movimientosI + " movimientos\n");
                                run = true;
                                break;
                            case "R":
                                Console.WriteLine("\nHas seleccionado el método R\n");
                                Pila iniR = new Pila(piezas);
                                Pila auxR = new Pila();
                                Pila finR = new Pila();
                                int movimientosR = new Hanoi().recursivo(piezas, iniR, finR, auxR);
                                Console.WriteLine("Resuelto en " + movimientosR + " movimientos\n");
                                run = true;
                                break;
                            default:
                                Console.WriteLine("Por favor, seleccione I para modo iterativo o R para modo recursivo. No se admiten mas opciones\n");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No se admiten palabras, intruduzca de manera numerica el numero de piezas que quiere.\n");
                }

                if (run)
                {
                    Console.WriteLine("Pulse cualquier tecla para continuar o pulse 0 para salir\n");
                    String respuestaString = Console.ReadLine();
                    if (Int32.TryParse(respuestaString, out int respuesta))
                    {
                        if (respuesta == 0)
                        {
                            Console.WriteLine("Hasta luego.\n");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saliendo del programa.\n");
                        Environment.Exit(0);
                    }
                }
            } while (true);
        }
    }
}
