using ListasSimplementeLigadas;

Lista listas = new Lista();
listas.AgregarNodo("Cero");
listas.AgregarNodo("Uno");
listas.AgregarNodo("Dos");
listas.AgregarNodo("Ocho");
Nodo nodoBusqueda = listas.BuscarAnterior("Dos");
Console.WriteLine(nodoBusqueda.Valor);
//Console.WriteLine("Buscando nodo Dos");
//Nodo nodoDos = listas.Buscar("Dos");
//Console.WriteLine(nodoDos.Valor);
//Console.WriteLine("Borrando Dos");
//listas.BorrarNodo("Dos");
//Console.WriteLine(listas.RecorrerLista());