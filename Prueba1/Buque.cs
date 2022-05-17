using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1{
    internal class Buque {
        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gTransporte;
        private List<Container> listaContainers = new List<Container>();
        public string Codigo {get => codigo;}
        public string Nombre {get => nombre; set => nombre = value;}
        public string Pais {get => pais; set => pais = value;}
        public int CantidadContainers {get => cantidadContainers; set => cantidadContainers = value;}
        public int CantidadContainersCargados {
            get => cantidadContainersCargados;
            set{
                if (value > cantidadContainers) cantidadContainersCargados = cantidadContainers;
                else cantidadContainersCargados = value;
            }
        }
        public int gEnvio {get => gTransporte; set => gTransporte = value;}
        public List<Container> ListaContainers {get => listaContainers;}
        public Buque(string codigo, int gTransporte = 0, int cantidadContainers = 20, int cantidadContainersCargados = 0, string nombre = "Sin especificar", string pais = "Sin especificar") {
            if (codigo.Length < 5){
                for (int i = 0; i < (5 - codigo.Length); i++){
                    codigo = string.Concat("0", codigo);
                }
            }
            this.gTransporte = gTransporte;
            this.codigo = codigo;
            this.cantidadContainers = cantidadContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.nombre = nombre;
            this.pais = pais;
        }
        public bool sContainer(Container container){
            if (container.Tamaño == 40){
                if (cantidadContainersCargados == 39) return false;
            }
            else if (container.Tamaño == 20){
                if (cantidadContainersCargados == 40) return false;
            }
            listaContainers.Add(container);
            cantidadContainersCargados++;
            if (container.Tamaño == 40){
                listaContainers.Add(container);
                cantidadContainersCargados++;
            }
            return true;
        }
    }
}