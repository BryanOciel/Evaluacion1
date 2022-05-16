using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear 2 buques */
            Buque uno = new Buque("35899", 551465,2,20,"Titanic","Uruguay");
            Buque dos = new Buque("35877", 565456, 5, 20, "Esmeralda", "Chile");
            /* Crear 4 containers y asociarlos a un buque. El cuarto container que cree, lo debe ser creado con el peso máximo
            que se puede cargar. */
            Container primero = new Container("00001", uno, 43000);
            Container segundo = new Container("00002", uno, 91000);
            Container tercero = new Container("00003", dos, 82000);
            Container cuarto = new Container("00004", dos, 200000, 200000);
            uno.SubirContainer(primero);
            uno.SubirContainer(segundo);
            dos.SubirContainer(tercero);
            dos.SubirContainer(cuarto);
            /* Listar los datos de cada containers que se encuentran en el buque */
            Console.WriteLine("Contenedores Buque 35899");
            Console.WriteLine(".......................................");
            foreach (Container c in uno.ListaContainers)
            {
                Console.WriteLine("Container");
                Console.WriteLine("Codigo: " + c.Codigo);
                Console.WriteLine("Marca: " + c.Marca);
                Console.WriteLine("Pais: " + c.buque.Pais);
                Console.WriteLine("Capacidad maxima: " + c.CapacidadMaxima + " kg");
                Console.WriteLine("Tamaño: " + c.Tamaño + " pies de altura");
                Console.Write("Refrigerado: ");

                if (c.EsRefrigerado) Console.WriteLine("Si");
                else Console.WriteLine("No");

                Console.WriteLine("Peso Actual: " + c.PesoActual + " kg");
                Console.WriteLine(".......................................");
            }
            Console.WriteLine();
            Console.WriteLine("Contenedores Buque 35877");
            Console.WriteLine(".......................................");
            foreach (Container c in dos.ListaContainers)
            {
                Console.WriteLine("Codigo: " + c.Codigo);
                Console.WriteLine("Marca: " + c.Marca);
                Console.WriteLine("Pais: " + c.buque.Pais);
                Console.WriteLine("Capacidad maxima: " + c.CapacidadMaxima + " kg");
                Console.WriteLine("Tamaño: " + c.Tamaño + " pies de altura");
                Console.Write("Refrigerado: ");

                if (c.EsRefrigerado) Console.WriteLine("Si");
                else Console.WriteLine("No");

                Console.WriteLine("Peso Actual: " + c.PesoActual + " kg");
                Console.WriteLine(".......................................");
            }
            Console.WriteLine();
            /* Mostrar el valor a pagar por conceptos de inspección para el container 3. */
            Console.WriteLine("Valor inspección del tercer container: " + tercero.ValorPagoInspeccion() + " CLP");
            Console.WriteLine();
            /* Mostrar el valor que debe pagar cada uno de los containers creados por conceptos de gastos de envío. */
            Console.WriteLine("Valor Por El Envio De cada Container");
            Console.WriteLine(".......................................");
            Console.WriteLine("Buque 35899 numero container " + primero.Codigo + " el precio del envio es: " + primero.CalcularGastosEnvio() + " CLP");
            Console.WriteLine("Buque 35899 numero container " + segundo.Codigo + " el precio del envio es: " + segundo.CalcularGastosEnvio() + " CLP");
            Console.WriteLine("Buque 35877 numero container " + tercero.Codigo + " el precio del envio es: " + tercero.CalcularGastosEnvio() + " CLP");
            Console.WriteLine("Buque 35877 numero container " + cuarto.Codigo + " el precio del envio es: " + cuarto.CalcularGastosEnvio() + " CLP");
            Console.WriteLine(".......................................");
            Console.WriteLine();
            /* Mostrar si al container 4 puedo subir una caja con mercadería que pesa 2000 kilos. */
            if (cuarto.PuedeSubir(2000)) Console.WriteLine("Se Puede subir una caja de 2000 kilos en el container "+ cuarto.Codigo+".");
            else Console.WriteLine("No se puede subir una caja de 2000 kilos en el container "+ cuarto.Codigo+".");
            Console.WriteLine();
            /* Quitar 200 kilos al primer container. */
            primero.SacarPeso(200);
            Console.WriteLine("Peso del primer container: " + primero.PesoActual + " kg");
            Console.ReadKey();
        }
    }
}