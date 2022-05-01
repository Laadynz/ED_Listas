using ListasDoblementeLigadas;

Lista listas = new Lista();

Console.WriteLine("Mostrando elementos de la lista");
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Ocho");
Console.WriteLine(listas.RecorrerLista());


Console.WriteLine("Buscando nodo Dos");
Nodo nodoBusqueda = listas.Buscar("Dos");
Console.WriteLine(nodoBusqueda.Valor);
Console.WriteLine("");

Console.WriteLine("Buscando nodo anterior al Dos");
Nodo nodoDos = listas.Buscar("Dos");
Console.WriteLine(nodoDos.Anterior.Valor);

Console.WriteLine("");
Console.WriteLine("Borrando Dos");
listas.BorrarNodo("Dos");
Console.WriteLine(listas.RecorrerLista());
