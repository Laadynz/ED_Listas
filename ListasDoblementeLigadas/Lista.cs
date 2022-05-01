using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    public class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
        }
        public bool ValidaVacio()
        {
            return (nodoInicial.Siguiente == null);
        }
        public void Vaciar()
        {
            nodoInicial.Siguiente = null;
        }
        public string RecorrerLista()
        {
            string datosLista = "";
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datosLista += $"{nodoActual.Valor}\n";
            }
            return datosLista;
        }
        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nodoNuevo = new Nodo(dato);
            nodoActual.Siguiente = nodoNuevo;
            nodoNuevo.Anterior = nodoActual;
        }
        public Nodo Buscar(string dato)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Valor == dato)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }


        public void BorrarNodo(string dato)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(dato);
                if (nodoActual != null)
                {

                    nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;

                }
            }

        }
    }
}
