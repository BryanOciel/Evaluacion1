using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    internal class Container
    {
        private string codigo;
        private string marca;
        private int CaMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pActual;
        public Buque buque;
        public string Codigo {get => codigo;}
        public string Marca {get => marca; set => marca = value;}
        public int caMaxima {get => CaMaxima; set => CaMaxima = value;}
        public byte Tamaño {get => tamaño; set => tamaño = value;}
        public bool EsRefrigerado {get => esRefrigerado; set => esRefrigerado = value;}
        public int PActual
        {
            get => pActual;
            set
            {
                if (value < 0) pActual = 0;
                else if (value > CaMaxima) pActual = CaMaxima;
                else pActual = value;
            }
        }
        public Container(string codigo, Buque buque = null, int pActual = 0, int CaMaxima = 100000, byte tamaño = 20, string marca = "Sin especificar", bool esRefrigerado = false)
        {
            this.codigo = codigo;
            this.buque = buque;
            this.caMaxima = CaMaxima;
            this.pActual = pActual;
            if (tamaño >= 30) tamaño = 40;
            this.marca = marca;
            this.esRefrigerado = esRefrigerado;
        }
        public void SacarPeso(int peso)
        {
            pActual -= peso;
            if (pActual < 0) pActual = 0;
        }
        public int ValorPagoInspeccion()
        {
            return (pActual * 5);
        }
        public int CalcularGastosEnvio()
        {
            int gEnvio = buque.gEnvio / buque.CantidadContainers;
            if (tamaño == 40)
            {
                gEnvio += gEnvio + 10000;
            }
            else gEnvio += 5000;
            return gEnvio;
        }
        public bool PuedeSubir(int peso)
        {
            if ((peso + pActual) > CaMaxima) return false;
            else return true;
        }
    }
}
