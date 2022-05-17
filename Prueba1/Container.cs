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
        private int capacidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        public Buque buque;
        public string Codigo {get => codigo;}
        public string Marca {get => marca; set => marca = value;}
        public int CapacidadMaxima {get => capacidadMaxima; set => capacidadMaxima = value;}
        public byte Tamaño {get => tamaño; set => tamaño = value;}
        public bool EsRefrigerado {get => esRefrigerado; set => esRefrigerado = value;}
        public int PesoActual
        {
            get => pesoActual;
            set
            {
                if (value < 0) pesoActual = 0;
                else if (value > capacidadMaxima) pesoActual = capacidadMaxima;
                else pesoActual = value;
            }
        }
        public Container(string codigo, Buque buque = null, int pesoActual = 0, int capacidadMaxima = 100000, byte tamaño = 20, string marca = "Sin especificar", bool esRefrigerado = false)
        {
            this.codigo = codigo;
            this.buque = buque;
            this.capacidadMaxima = capacidadMaxima;
            this.pesoActual = pesoActual;
            // Si la condición no se cumple, el container será creado con el valor 20.
            if (tamaño >= 30) tamaño = 40;
            this.marca = marca;
            this.esRefrigerado = esRefrigerado;
        }
        /// Remueve aproximadamente un 10% del peso de carga.
        public void SacarPeso(int peso)
        {
            pesoActual -= peso;
            if (pesoActual < 0) pesoActual = 0;
        }
        /// Calcula el valor que se pagara por una inspeccion.
        /// Valor de la inspección.
        public int ValorPagoInspeccion()
        {
            return (pesoActual * 5);
        }
        /// Calcula el gasto del envio.
        /// Valor del gasto.
        public int CalcularGastosEnvio()
        {
            int gastoEnvio = buque.GastoEnvio / buque.CantidadContainers;
            if (tamaño == 40)
            {
                gastoEnvio += gastoEnvio + 9000;
            }
            else gastoEnvio += 3500;
            return gastoEnvio;
        }
        /// Determina si el container se puede cargar sin exceder el limite establecido.
        /// <param name="peso"></param>
        /// True si puede cargarse, y false si se excede el peso maximo extablesido.
        public bool PuedeSubir(int peso)
        {
            if ((peso + pesoActual) > capacidadMaxima) return false;
            else return true;
        }
    }
}
