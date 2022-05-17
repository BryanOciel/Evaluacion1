using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1{
    internal class Program{
        static void Main(string[] args) {
            Buque a = new Buque("35899", 551465,2,20,"Titanic","Uruguay");
            Buque b = new Buque("35877", 565456, 5, 20, "Esmeralda", "Chile");
            Container c = new Container("15423", a, 45100);
            Container d = new Container("25681", b, 51500);
            Container j = new Container("36898", a, 72800);
            Container p = new Container("49862", b, 200000, 200000);
             a.sContainer(c);
             a.sContainer(d);
             b.sContainer(j);
             b.sContainer(p);
            Console.WriteLine("Containers Buque 35899");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Container f = new Container(null);
            int aux=0;
            for (int i = 0; i < 4; i++)
            {
                if (i < 2) { f = a.ListaContainers[i]; }
                else
                {
                    f = b.ListaContainers[aux];
                    aux = aux + 1;
                    Console.WriteLine();
                    Console.WriteLine("Containers Buque 35877");
                    Console.WriteLine("+++++++++++++++++++++++++++");
                }
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
            Console.WriteLine("Valor Por El Envio De cada Container y su codigo es:");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Buque 35899| numero container " + c.Codigo + " el precio del envio es: $" + c.CalcularEnvio() + "|");
            Console.WriteLine("Buque 35899| numero container " + d.Codigo + " el precio del envio es: $" + d.CalcularEnvio() + "|");
            Console.WriteLine("Buque 35877| numero container " + j.Codigo + " el precio del envio es: $" + j.CalcularEnvio() + "|");
            Console.WriteLine("Buque 35877| numero container " + p.Codigo + " el precio del envio es: $" + p.CalcularEnvio() + "|");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Valor a Pagar Por Inspeccion Container "+ c.Codigo+": $" + j.ValorInspeccion() + "|");
            Console.WriteLine();
                 if (p.PuedeSubir(2000)) Console.WriteLine("Subir Caja de 2000 kilos al container "+ p.Codigo+"|");
                 else Console.WriteLine("No subir caja de 2000 kilos al container "+ p.Codigo+" por que excede el maximo permitido|");
            Console.WriteLine();
                 c.SacarPeso(200);
            Console.WriteLine("Peso del primer container restando los 200kg: " + c.PActual + "kg|");
            Console.ReadKey();
        }
    }
}