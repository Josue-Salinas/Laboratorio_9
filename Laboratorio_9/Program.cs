using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_9
{
    internal class Program
    {
        static void Main()
        {
            string opciones;
            do
            {
                tabla_tienda();

                opciones = Console.ReadLine();
                switch (opciones)
                {
                    case "1":
                        Console.WriteLine("Registrar Venta");
                        Registrar_Venta();
                        break;
                    case "2":
                        Console.WriteLine("Registrar devolución");
                        Registrar_devolucion();
                        break;
                    case "3":
                        Console.WriteLine("Cerrar Caja");
                        cerrar_caja();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            } while (opciones != "3");
        }

        static void tabla_tienda()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("=================================");
            Console.WriteLine("Ingrese una opción:");
        }
        static void Registrar_Venta()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar Venta de:");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5 <- Regresar");
            Console.WriteLine("=================================");
            Console.WriteLine("Ingrese una opción");
            string registro_venta = Console.ReadLine();
            switch (registro_venta)
            {
                case "1":
                    Console.WriteLine("Limpieza");
                    registro_limpieza();
                    break;
                case "2":
                    Console.WriteLine("Abarrotes");
                    registro_abarrotes();
                    break;
                case "3":
                    Console.WriteLine("Golosinas");
                    registro_golosinas();
                    break;
                case "4":
                    Console.WriteLine("Electrónicos");
                    registro_electronicos();
                    break;
                case "5":
                    Console.WriteLine("Regresar");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        static void registro_limpieza()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Limpieza:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de limpieza");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registro_abarrotes()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Abarrotes:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de abarrotes");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registro_golosinas()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Golosinas:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de golosinas");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registro_electronicos()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar venta de Electrónicos:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de electrónicos");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }


        static void Registrar_devolucion()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5 <- Regresar");
            Console.WriteLine("=================================");
            Console.WriteLine("Ingrese una opción");

            string registro_devolucion = Console.ReadLine();
            switch (registro_devolucion)
            {
                case "1":
                    Console.WriteLine("Limpieza");
                    registros_limpieza();
                    break;
                case "2":
                    Console.WriteLine("Abarrotes");
                    registros_abarrotes();
                    break;
                case "3":
                    Console.WriteLine("Golosinas");
                    registros_golosinas();
                    break;
                case "4":
                    Console.WriteLine("Electrónicos");
                    registros_electronicos();
                    break;
                case "5":
                    Console.WriteLine("Regresar");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        static void registros_limpieza()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Limpieza:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;

            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de limpieza");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registros_abarrotes()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Abarrotes:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de abarrotes");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registros_golosinas()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Golosinas:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");

            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de golosinas");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }
        }
        static void registros_electronicos()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Registrar devolución de Electronicos:");
            Console.WriteLine("=================================");
            Console.Write("Ingrese cantidad (unidades):");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            double precio = double.Parse(Console.ReadLine());
            double subtotal = cantidad * precio;
            Console.WriteLine("=================================");
            Console.WriteLine($"Se han ingresado {cantidad} unidades ");
            Console.WriteLine($"Sen han ingresado S/{subtotal} en caja");
            Console.WriteLine("=================================");
            Console.WriteLine("1: Registrar más productos de electronicos");
            Console.WriteLine("2: <-Regresar");
            Console.WriteLine("Ingrese una opción");

            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Registrar_Venta();
            }
            else if (opcion == "2")
            {

            }

        }
        static void cerrar_caja()
        {


            Console.WriteLine("=================================");
            Console.WriteLine("Totales");
            Console.WriteLine("=================================");
            Console.WriteLine("Limpieza");
        }
    }
}

    


