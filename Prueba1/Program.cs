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
            Container pri = new Container("15423", uno, 45100);
            Container seg = new Container("25681", uno, 51500);
            Container ter = new Container("36898", dos, 72800);
            Container cua = new Container("49862", dos, 200000, 200000);
            uno.SubirContainer(pri);
            uno.SubirContainer(seg);
            dos.SubirContainer(ter);
            dos.SubirContainer(cua);
            /* Listar los datos de cada containers que se encuentran en el buque */
            Console.WriteLine("Contenedores Buque 35899");
            Console.WriteLine(".......................................");
            foreach (Container c in uno.ListaContainers)
            {
                Console.WriteLine("Container");
                Console.WriteLine("Codigo: " + c.Codigo);
                Console.WriteLine("Marca: " + c.Marca);
                Console.WriteLine("Pais: " + c.buque.Pais);
                Console.WriteLine("Capacidad maxima: " + c.caMaxima + " kg");
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
                Console.WriteLine("Capacidad maxima: " + c.caMaxima + " kg");
                Console.WriteLine("Tamaño: " + c.Tamaño + " pies de altura");
                Console.Write("Refrigerado: ");

                if (c.EsRefrigerado) Console.WriteLine("Si");
                else Console.WriteLine("No");

                Console.WriteLine("Peso Actual: " + c.PesoActual + " kg");
                Console.WriteLine(".......................................");
            }
            Console.WriteLine();
            /* Mostrar el valor a pagar por conceptos de inspección para el container 3. */
            Console.WriteLine("Valor inspección del tercer container: " + ter.ValorPagoInspeccion() + " CLP");
            Console.WriteLine();
            /* Mostrar el valor que debe pagar cada uno de los containers creados por conceptos de gastos de envío. */
            Console.WriteLine("Valor Por El Envio De cada Container");
            Console.WriteLine(".......................................");
            Console.WriteLine("Buque 35899 numero container " + pri.Codigo + " el precio del envio es: " + pri.CalcularGastosEnvio() + " CLP");
            Console.WriteLine("Buque 35899 numero container " + seg.Codigo + " el precio del envio es: " + seg.CalcularGastosEnvio() + " CLP");
            Console.WriteLine("Buque 35877 numero container " + ter.Codigo + " el precio del envio es: " + ter.CalcularGastosEnvio() + " CLP");
            Console.WriteLine("Buque 35877 numero container " + cua.Codigo + " el precio del envio es: " + cua.CalcularGastosEnvio() + " CLP");
            Console.WriteLine(".......................................");
            Console.WriteLine();
            /* Mostrar si al container 4 puedo subir una caja con mercadería que pesa 2000 kilos. */
            if (cua.PuedeSubir(2000)) Console.WriteLine("Se Puede subir una caja de 2000 kilos en el container "+ cua.Codigo+".");
            else Console.WriteLine("No se puede subir una caja de 2000 kilos en el container "+ cua.Codigo+".");
            Console.WriteLine();
            /* Quitar 200 kilos al primer container. */
            pri.SacarPeso(200);
            Console.WriteLine("Peso del primer container: " + pri.PesoActual + " kg");
            Console.ReadKey();
        }
    }
}