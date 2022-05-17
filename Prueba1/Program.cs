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
            Buque a = new Buque("35899", 551465,2,20,"Titanic","Uruguay");
            Buque b = new Buque("35877", 565456, 5, 20, "Esmeralda", "Chile");
            Container pri = new Container("15423", a, 45100);
            Container seg = new Container("25681", b, 51500);
            Container ter = new Container("36898", a, 72800);
            Container cua = new Container("49862", b, 200000, 200000);
             a.sContainer(pri);
             a.sContainer(seg);
             b.sContainer(ter);
             b.sContainer(cua);
            Console.WriteLine("Containers Buque 35899");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            foreach (Container f in a.ListaContainers)
            {
                Console.WriteLine("Codigo Container: " + f.Codigo);
                Console.WriteLine("Marca: " + f.Marca);
                Console.WriteLine("Pais: " + f.buque.Pais);
                Console.WriteLine("Capacidad maxima: " + f.caMaxima + "kg|");
                Console.WriteLine("Tamaño: " + f.Tamaño + " pies de altura|");
                Console.Write("Es Un Container Refrigerado: ");
                if (f.EsRefrigerado) Console.WriteLine("Si|");
                else Console.WriteLine("No|");
                Console.WriteLine("Peso Actual Del Container: " + f.PActual + "kg|");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.WriteLine();
            Console.WriteLine("Containers Buque 35877");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            foreach (Container f in b.ListaContainers)
            {
                Console.WriteLine("Codigo Container: " + f.Codigo);
                Console.WriteLine("Marca: " + f.Marca);
                Console.WriteLine("Pais: " + f.buque.Pais);
                Console.WriteLine("Capacidad maxima: " + f.caMaxima + "kg|");
                Console.WriteLine("Tamaño: " + f.Tamaño + " pies de altura|");
                Console.Write("Es Un Container Refrigerado: ");
                if (f.EsRefrigerado) Console.WriteLine("Si|");
                else Console.WriteLine("No|");
                Console.WriteLine("Peso Actual Del Container: " + f.PActual + "kg|");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            }
            Console.WriteLine();
            Console.WriteLine("Valor Por El Envio De cada Container y su codigo es:");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Buque 35899| numero container " + pri.Codigo + " el precio del envio es: $" + pri.CalcularEnvio() + "|");
            Console.WriteLine("Buque 35899| numero container " + seg.Codigo + " el precio del envio es: $" + seg.CalcularEnvio() + "|");
            Console.WriteLine("Buque 35877| numero container " + ter.Codigo + " el precio del envio es: $" + ter.CalcularEnvio() + "|");
            Console.WriteLine("Buque 35877| numero container " + cua.Codigo + " el precio del envio es: $" + cua.CalcularEnvio() + "|");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Valor a Pagar Por Inspeccion Container "+ ter.Codigo+": $" + ter.ValorInspeccion() + "|");
            Console.WriteLine();
                 if (cua.PuedeSubir(2000)) Console.WriteLine("Subir Caja de 2000 kilos al container "+ cua.Codigo+"|");
                 else Console.WriteLine("No subir caja de 2000 kilos al container "+ cua.Codigo+"|");
            Console.WriteLine();
                 pri.SacarPeso(200);
            Console.WriteLine("Peso del primer container restando los 200kg: " + pri.PActual + "kg|");
            Console.ReadKey();
        }
    }
}