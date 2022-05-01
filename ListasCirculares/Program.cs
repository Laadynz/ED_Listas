
using ListasCirculares;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Ocho");
Console.WriteLine(listas.RecorrerLista());
Console.WriteLine("Buscando el siguiente al Ocho");
Nodo nodoBusqueda = listas.Buscar("Ocho");
Console.WriteLine(nodoBusqueda.Enlace.Valor);
Console.WriteLine("Buscando nodo Dos");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Valor);
Console.WriteLine("Borrando Dos");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());
