// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {

        int opcionmenu;
        int numeroFactura = 0;
        int cantidadproductos;
        int cantidad1 = 0, cantidad2 = 0, cantidad3 = 0, cantidad4 = 0, cantidad5 = 0;
        int totalPuntos = 0;

        do
        {
            // Menú principal
            Console.WriteLine("Bienvenido");
            Console.WriteLine("1. FACTURACIÓN");
            Console.WriteLine("2. REPORTES DE FACTURACIÓN");
            Console.WriteLine("3. SALIR");
            opcionmenu = int.Parse(Console.ReadLine());

            // Ejecutar el menú

            {
                switch (opcionmenu)
                {
                    case 1:
                        Console.Clear();
                        string nit, email, nombreCliente;
                        int codigoProducto, cantidad;
                        double totalCompra = 0, impuestoISR, impuestoIVA, subtotal;
                        int acumuladorPuntos = 0, metodoPago, cantidadProductos = 0;
                        bool ingresarProducto = true;



                        // Pedir información del cliente
                        Console.WriteLine("Ingrese el NIT del cliente:");
                        nit = Console.ReadLine();
                        Console.WriteLine("Ingrese el correo electrónico del cliente:");
                        email = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del cliente:");
                        nombreCliente = Console.ReadLine();


                        // Pedir información de los productos
                        Console.WriteLine("Ingrese los productos que el cliente desea comprar:");
                        Console.WriteLine("Producto: | ---Pan frances.                      | --- Precio: Q.1.10   | --- Código: 001 --- |");
                        Console.WriteLine("Producto: | ---Libra de azúcar.                  | --- Precio: Q.5.00   | --- Código: 002 --- |");
                        Console.WriteLine("Producto: | ---Cajas de galletas.                | --- Precio: Q.7.30   | --- Código: 003 --- |");
                        Console.WriteLine("Producto: | ---Caja de granaola.                 | --- Precio: Q.32.50  | --- Código: 004 --- |");
                        Console.WriteLine("Producto: | ---Litro de jugo de naranja.         | --- Precio: Q.17.95  | --- Código: 005 --- |");
                        while (ingresarProducto)
                        {

                            Console.WriteLine("Ingrese el código del producto:");
                            codigoProducto = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de unidades:");
                            cantidad = int.Parse(Console.ReadLine());

                            if (codigoProducto == 1)
                            {
                                totalCompra += cantidad * 1.10;
                            }
                            else if (codigoProducto == 2)
                            {
                                totalCompra += cantidad * 5.00;
                            }
                            else if (codigoProducto == 3)
                            {
                                totalCompra += cantidad * 7.30;
                            }
                            else if (codigoProducto == 4)
                            {
                                totalCompra += cantidad * 32.50;
                            }
                            else if (codigoProducto == 5)
                            {
                                totalCompra += cantidad * 17.95;
                            }
                            else
                            {
                                Console.WriteLine("Código de producto incorrecto. Intente nuevamente.");
                            }

                            if (cantidad > 0 && codigoProducto >= 1 && codigoProducto <= 5)
                            {
                                cantidadProductos += cantidad;
                                Console.WriteLine("Producto agregado a la factura.");

                                Console.WriteLine("¿Desea ingresar otro producto? (1 para sí, 0 para no)");
                                int opcion = int.Parse(Console.ReadLine());
                                if (opcion == 0)
                                {
                                    ingresarProducto = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Cantidad de productos inválida. Intente nuevamente.");
                            }
                        }

                        // Calcular impuestos y subtotal
                        impuestoISR = totalCompra * 0.05;
                        impuestoIVA = totalCompra * 0.12;
                        subtotal = totalCompra - impuestoISR - impuestoIVA;

                        // Pedir método de pago
                        Console.WriteLine("Ingrese el método de pago (1 para efectivo, 2 para tarjeta de crédito):");
                        metodoPago = int.Parse(Console.ReadLine());

                        if (metodoPago == 2)
                        {
                            // Calcular puntos acumulados por cliente
                            if (totalCompra < 50)
                            {
                                acumuladorPuntos = (int)(totalCompra / 10);
                                totalPuntos += acumuladorPuntos;

                            }
                            else if (totalCompra >= 50 && totalCompra < 150)
                            {
                                acumuladorPuntos = (int)(totalCompra / 10) * 2;
                                totalPuntos += acumuladorPuntos;
                            }
                            else
                            {
                                acumuladorPuntos = (int)(totalCompra / 15) * 3;
                                totalPuntos += acumuladorPuntos;
                            }
                        }

                        // Generar número de factura



                        // Impresión de factura


                        numeroFactura++;
                        Console.WriteLine("----- FACTURA -----");
                        Console.WriteLine("Numero de factura :" + numeroFactura);
                        Console.WriteLine($"Nombre de la factura: {nombreCliente}");
                        Console.WriteLine($"NIT: {nit}");
                        Console.WriteLine($"Correo electrónico del cliente: {email}");
                        Console.WriteLine();
                        // Imprimir los productos comprados
                        Console.WriteLine();
                        Console.WriteLine("Productos comprados:");
                        Console.WriteLine("--------------------");
                        if (cantidad1 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Libra azucar: " + cantidad1 + "| -- Precio unitario = 10.80 --" + "| -- Precio total: " + cantidad1 * 10.80 + " -- | ");
                        }
                        if (cantidad2 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Libra arroz: " + cantidad2 + " | -- Precio unitario = 3.80 --" + " | -- Precio total: " + cantidad2 * 3.80 + " -- | ");
                        }
                        if (cantidad3 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Galleta GAMA: " + cantidad3 + "| -- Precio unitario = 1.10 --" + " | -- Precio total: " + cantidad3 * 1.10 + " -- | ");
                        }
                        if (cantidad4 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Coca cola: " + cantidad4 + "   | -- Precio unitario = 17.00" + "   | -- Precio total: " + cantidad4 * 17.00 + " -- | ");
                        }
                        if (cantidad5 > 0)
                        {
                            Console.WriteLine("| -- Cantidad Libras cafe " + cantidad5 + "  | -- Precio unitario = 50.00" + "   | -- Precio total: " + cantidad5 * 50.00 + " -- | ");
                        }
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Total: " + totalCompra);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Puntos acumulados: " + acumuladorPuntos);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        //Reportes de facturación
                        Console.Clear();
                        cantidadproductos = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
                        Console.WriteLine("-------REPORTES DE FACTURACION-------");
                        Console.WriteLine("| ---Facturas totales: " + numeroFactura + "----------------- |");
                        Console.WriteLine("| ---Cantidad de productos vendidos: " + cantidadproductos + "--- |");
                        Console.WriteLine("| ---Cantidad de puntos generados: " + totalPuntos + "----- |");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        //Salida del programa
                        Console.Clear();
                        Console.WriteLine("------- SALIO DEL PROGRAMA -------");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
            }
        } while (opcionmenu != 3);
    }
}
